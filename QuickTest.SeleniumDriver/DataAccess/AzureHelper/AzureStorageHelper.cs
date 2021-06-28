using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AzureStorageHelper
    {
        public static async Task<string> UploadFileToStorage(string fileName, byte[] image)
        {
            string connectionString = Environment.GetEnvironmentVariable("AZURE_TEST_STORAGE");
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("quicktestcontainer");
            BlobClient blobClient = containerClient.GetBlobClient(fileName);
            BlobUploadOptions options = new BlobUploadOptions();
            options.HttpHeaders = new BlobHttpHeaders() { ContentType = "image/jpeg" };
            await blobClient.UploadAsync(BinaryData.FromBytes(image), options);
            string imageLink = "https://quicktestimages.blob.core.windows.net/quicktestcontainer/" + fileName;
            return imageLink;
        }
    }
}
