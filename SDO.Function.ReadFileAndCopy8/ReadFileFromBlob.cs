using System.IO;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Azure.WebJobs;

namespace SDO.Function.ReadFileAndCopy8
{
    public class ReadFileFromBlob
    {
        private readonly ILogger<ReadFileFromBlob> _logger;
        private const string registryContainer = "anagrafica";
        private const string clinicalContainer = "clinica";

        public ReadFileFromBlob(ILogger<ReadFileFromBlob> logger)
        {
            _logger = logger;
        }

        [Function(nameof(ReadFileFromBlob))]
        public async Task RunAsync([BlobTrigger("anagrafica/{name}", Connection = "BlobConnectionString")] Stream myBlob, string name, ILogger log, Microsoft.Azure.WebJobs.ExecutionContext context)
        {
            bool isClinical = false;
            string[] suffixplit = name.Split('.');
            if (suffixplit[0].EndsWith("SDO_CLI"))
                isClinical = true;

            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(context.FunctionAppDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();
            string connectionString = config["BlobConnectionString"];

            CopyToAnotherContainer(connectionString, isClinical, name, log);


            Console.ReadLine();
        }
        private static async Task CopyToAnotherContainer(string connectionString, bool isClinical, string name, ILogger log)
        {
            string appParameter = "BlobConnectionString";
            string sourceConnString = Environment.GetEnvironmentVariable($"{appParameter}");

            BlobClient sourceBlobClient = new(
                connectionString,
                isClinical ? clinicalContainer : registryContainer,
                name);

            Uri sourceBlobSasToken = sourceBlobClient.GenerateSasUri(Azure.Storage.Sas.BlobSasPermissions.Read, DateTimeOffset.Now.AddHours(2));

            BlobClient destBlobClient = new(
                connectionString,
                isClinical ? $"{clinicalContainer}-copy" : $"{registryContainer}-copy",
                name);

            CopyFromUriOperation copyTask = await destBlobClient.StartCopyFromUriAsync(sourceBlobSasToken);

        }
    }
}
