using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SDO.Function.ReadFileAndCopy
{
    public class ReadFileFromBlob
    {
		private const string registryContainer = "anagrafica";
		private const string clinicalContainer = "clinica";

		[FunctionName("ReadFileFromBlob")]
        public static async Task RunAsync([BlobTrigger("anagrafica/{name}", Connection = "BlobConnectionString")]Stream myBlob,
            string name,
            ILogger log,
			ExecutionContext context)
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
