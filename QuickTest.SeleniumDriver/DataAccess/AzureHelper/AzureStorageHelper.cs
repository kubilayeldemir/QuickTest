using Azure.Storage;
using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
            var x = await blobClient.UploadAsync(BinaryData.FromBytes(image));
            string imageLink = "https://quicktestimages.blob.core.windows.net/quicktestcontainer/" + fileName;
            return imageLink;
        }
    }
}
