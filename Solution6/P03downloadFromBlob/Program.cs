// See https://aka.ms/new-console-template for more information

using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System.IO;
using System.Reflection.Metadata;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyball1storage1ra;AccountKey=Jo2wBaraoaHJXuu3R+ak3qYYJdZvDdrvbtsIocWwDXOqcULv6unmPm2rPWO+/++FBPrEhUcjMML2+AStPPFrFw==;EndpointSuffix=core.windows.net";
var containerName = "volleyballpictures";
var blobServiceClient = new BlobServiceClient(connectionString);
var containerClient = blobServiceClient.GetBlobContainerClient(containerName);

Console.WriteLine("Enter the name of the image to download from Blob storage: ");
var imageNameToDownload = Console.ReadLine();
var downloadBlobClient = containerClient.GetBlobClient(imageNameToDownload);
Console.WriteLine("Enter the destination file path to save the downloaded image: ");
var destinationPath = Console.ReadLine();
BlobDownloadInfo download = await downloadBlobClient.DownloadAsync();
using var downloadFileStream = File.OpenWrite(destinationPath);
await download.Content.CopyToAsync(downloadFileStream);
downloadFileStream.Close();
Console.WriteLine($"Image '{imageNameToDownload}' downloaded successfully from Blob storage and saved to '{destinationPath}'.");