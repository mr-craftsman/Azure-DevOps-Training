// See https://aka.ms/new-console-template for more information
/// azure portal file shares
/// 
using Azure;
using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;
using System.IO;


var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyball1storage1ra;AccountKey=Jo2wBaraoaHJXuu3R+ak3qYYJdZvDdrvbtsIocWwDXOqcULv6unmPm2rPWO+/++FBPrEhUcjMML2+AStPPFrFw==;EndpointSuffix=core.windows.net";


var shareName = "picturesshare";
ShareServiceClient shareServiceClient = new ShareServiceClient(connectionString);
ShareClient shareClient = shareServiceClient.GetShareClient(shareName);
ShareDirectoryClient directoryClient = shareClient.GetRootDirectoryClient();
Console.WriteLine("Enter the file path of the image to upload:");
var imagePath = Console.ReadLine();
using var fileStream = File.OpenRead(imagePath);
var fileName = Path.GetFileName(imagePath);
ShareFileClient fileClient = directoryClient.GetFileClient(fileName);
await fileClient.CreateAsync(fileStream.Length);
await fileClient.UploadRangeAsync(new HttpRange(0, fileStream.Length), fileStream);
Console.WriteLine($"Image '{imagePath}' uploaded successfully to the File Share.");

Console.WriteLine("Enter the name of the image to download from the File Share:");
var imageNameToDownload = Console.ReadLine();
var downloadFileClient = directoryClient.GetFileClient(imageNameToDownload);
Console.WriteLine("Enter the destination file path to save the downloaded image:");
var destinationPath = Console.ReadLine();
ShareFileDownloadInfo download = await downloadFileClient.DownloadAsync();
using var downloadFileStream = File.OpenWrite(destinationPath);
await download.Content.CopyToAsync(downloadFileStream);
downloadFileStream.Close();
Console.WriteLine($"Image '{imageNameToDownload}' downloaded successfully from the File Share and saved to '{destinationPath}'.");

