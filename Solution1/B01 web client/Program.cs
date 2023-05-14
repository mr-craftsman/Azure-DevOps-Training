using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace B01WebClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebClient weatherWebClient = new WebClient();

            string weatherUrl = "https://www.google.com/search?q=weather+zakopane";
            string weatherData = weatherWebClient.DownloadString(weatherUrl);

            // your proper folder path down here
            string resultPath = @"C:\Users\Radek\Projects\AzureTraining\Solution1\weatherData.html";
            File.WriteAllText(resultPath, weatherData);
            

            Console.WriteLine(weatherData);
            Console.ReadKey();
        }
    }
}
