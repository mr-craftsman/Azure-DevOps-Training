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

            string resultPath = @"E:\weatherData\weatherData.html";
            File.WriteAllText(resultPath, weatherData);
            

            Console.WriteLine(weatherData);
            Console.ReadKey();
        }
    }
}
