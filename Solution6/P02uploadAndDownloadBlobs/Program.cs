// See https://aka.ms/new-console-template for more information
using Azure.Storage.Blobs;
using System.IO;
using System.Reflection.Metadata;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyball1storage1ra;AccountKey=Jo2wBaraoaHJXuu3R+ak3qYYJdZvDdrvbtsIocWwDXOqcULv6unmPm2rPWO+/++FBPrEhUcjMML2+AStPPFrFw==;EndpointSuffix=core.windows.net";
var containerName = "volleyballpictures";
var blobServiceClient = new BlobServiceClient(connectionString);
var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
Console.WriteLine("Enter the file path of the image to upload:");
var imagePath = Console.ReadLine();
using var fileStream = File.OpenRead(imagePath);
var blobName = Path.GetFileName(imagePath);
var blobClient = containerClient.GetBlobClient(blobName);
await blobClient.UploadAsync(fileStream, true);

Console.WriteLine($"Image '{imagePath}' uploaded successfully to Blob storage.");
