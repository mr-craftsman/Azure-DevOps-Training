using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B05EXinArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchChar = "°";
            string endChar = ">";
            const string path = @"cities.txt";
            // const string absolutePath = @"C:\Users\Radek\Projects\AzureTraining\Solution2\B05EXinArrays\cities.txt";

            string[] citiesFromFile = File.ReadAllLines(path);

            Console.WriteLine("Check cities:");
            for (int i = 0; i < citiesFromFile.Length; i++)
                Console.WriteLine($"[{i + 1}] {citiesFromFile[i]}");

            while (true)
            {
                Console.WriteLine("select a city (enter the number)");
                string cityString = Console.ReadLine();
                int cityNumber = Convert.ToInt32(cityString);
                string city = citiesFromFile[cityNumber - 1];

                string address = $"https://www.google.com/search?q=weather+{city}";

                WebClient wc = new WebClient();
                string data = wc.DownloadString(address);

                try
                {
                    int index = data.IndexOf(searchChar);
                    int currentPosition = index;
                    int iterationCount = 0;

                    while (data.Substring(currentPosition, 1) != endChar)
                    {
                        iterationCount++;
                        currentPosition--;
                    }

                    string result = data.Substring(currentPosition + 1, index - currentPosition + 1);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Cannot get temperature");
                    continue;
                }
                
            }
            Console.ReadKey();
        }
    }
}
