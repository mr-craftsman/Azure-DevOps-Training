using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace B02_finding_city
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string celsiussearch = "°";
            string endChar = ">";
            WebClient weatherWebClient = new WebClient();
            while (true)
            {
                

                Console.WriteLine("Please provide a city name:");

                string searchedCity = Console.ReadLine();
                string weatherUrl = $"https://www.google.com/search?q=weather+{searchedCity}";
                string weatherData = weatherWebClient.DownloadString(weatherUrl);
                try
                {
                    int index = weatherData.IndexOf(celsiussearch);
                    int currentPos = index;
                    int iterationCount = 0;
                    while (weatherData.Substring(currentPos, 1) != endChar)

                    {
                        iterationCount++;
                        currentPos--;

                    }

                    string result = weatherData.Substring(currentPos + 1, index - currentPos + 1);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("unknown city");
                    continue;
                }
               
                
            }

           
            


            // while substring, index of if
            





            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
