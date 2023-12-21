using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs;
using Azure.Storage.Blobs;
using SDO.Infrastructure.Sql.Interfaces;
using System.Data;
using System.Reflection;
using ChoETL;
using Parquet.Schema;
using Microsoft.Extensions.Configuration;
using SDO.Infrastructure.Sql.Models;
using SDO.Function.CreateParquet8.Utilities;
using System.Text.Json;


namespace SDO.Function.CreateParquet8
{
    public class ImportTxtAndCreateParquet
    {
        private readonly ILogger<ImportTxtAndCreateParquet> _logger;
        private const string registryContainer = "anagrafica";
        private const string clinicalContainer = "clinica";

        public ImportTxtAndCreateParquet(ILogger<ImportTxtAndCreateParquet> logger)
        {
            _logger = logger;
        }

        [Function(nameof(ImportTxtAndCreateParquet))]
        public async Task Run([BlobTrigger("anagrafica-copy/{name}", Connection = "BlobConnectionString")] Stream myBlob, string name, ILogger log, Microsoft.Azure.WebJobs.ExecutionContext context)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");

            bool isClinical = false;
            string[] suffixplit = name.Split('.');
            if (suffixplit[0].EndsWith("SDO_CLI"))
                isClinical = true;

            if (suffixplit[1] == "txt")
                ReadFileAsync(isClinical, myBlob, name, log, context);


            //ReadTxt(name, log, context);


            Console.ReadLine();
        }

        private static async Task ReadFileAsync(bool isClinical, Stream blob, string name, ILogger log, Microsoft.Azure.WebJobs.ExecutionContext context)
        {
            List<IFileModel> objectList = new();

            using (StreamReader reader = new(blob))
            {
                int lineCounter = 1;
                while (!reader.EndOfStream)
                {
                    List<string> foundField = ReadFileUtility.FindFields(reader.ReadLine());
                    IFileModel fileModel;
                    if (isClinical) fileModel = new SDO_DATI_CLINICI();
                    else fileModel = new SDO_DATI_ANAGRAFICI();
                    fileModel.SetSequenceNumber(lineCounter);
                    IFileModel file = FileMapper.Map(fileModel, foundField);

                    objectList.Add(file);
                    log.LogInformation($"Found the {fileModel.GetType().Name}: {JsonSerializer.Serialize(file)}");

                    lineCounter++;
                }
            }

            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(context.FunctionAppDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();
            string connectionString = config["BlobConnectionString"];

            string jsonFile = JsonSerializer.Serialize((object[])objectList.ToArray());




            //string csvString = ConvertJsonToCsv(jsonFile);

            //using (ChoParquetWriter parquetWriter = new("output.parquet"))
            //{
            //	using (StringReader csv = new(csvString))
            //	{
            //		parquetWriter.Write(csv);
            //	}
            //}

            SaveParquet(connectionString, name, objectList, jsonFile);



            //await WriteJsonFileAsync(connectionString, jsonFile, isClinical, name, log);
        }

        private static async Task SaveParquet(
            string connectionString,
            string fileName,
            List<IFileModel> fileModels,
            string jsonFile)
        {
            try
            {
                // Create a BlobServiceClient
                BlobServiceClient blobServiceClient = new(connectionString);

                // Get a reference to the container
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("parquets");

                string[] splittedName = fileName.Split('.');
                // Create a blob client to upload the Parquet file
                BlobClient blobClient = containerClient.GetBlobClient($"{splittedName[0]}.parquet");


                DataTable dt = new();
                if (fileModels.Any())
                {
                    IFileModel fileModel = fileModels.FirstOrDefault();

                    PropertyInfo[] properties = fileModel.GetType().GetProperties();
                    List<DataField> fields = new();
                    int counter = 0;

                    foreach (IFileModel model in fileModels)
                    {
                        DataRow dataRow = dt.NewRow();
                        foreach (PropertyInfo property in properties)
                        {
                            if (!dt.Columns.Contains(property.Name))
                            {
                                Type type = property.PropertyType;
                                dt.Columns.Add(property.Name, type);
                            }

                            PropertyInfo currentProperty = model.GetType().GetProperties().FirstOrDefault(x => x.Name == property.Name);

                            dataRow[currentProperty.Name] = currentProperty.GetValue(model);
                        }
                        dt.Rows.Add(dataRow);
                    }
                }

                using (MemoryStream stream = new())
                {
                    using (ChoParquetWriter parquetWriter = new(inStream: stream))
                    {
                        parquetWriter.Write(dt);
                    }

                    // Set the stream position to the beginning before uploading
                    stream.Position = 0;

                    // Upload the Parquet file to Azure Blob Storage
                    await blobClient.UploadAsync(stream, true);
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
