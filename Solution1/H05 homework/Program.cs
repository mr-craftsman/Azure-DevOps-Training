using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
//Implement a program that uses the WebClient class to download
//an image from a URL and save it to a local folder.
namespace H05_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string imageURL = "https://images.freeimages.com/images/large-previews/3b2/prague-conference-center-1056491.jpg";
            string downloadPath = @"C:\Users\Radek\Projects\AzureTraining\Solution1\downloaded.jpg";
            using (WebClient imageClient = new WebClient())
            {
                imageClient.DownloadFile(new Uri(imageURL), downloadPath);
            }
          
            Console.ReadKey();
            
        }
    }
}
