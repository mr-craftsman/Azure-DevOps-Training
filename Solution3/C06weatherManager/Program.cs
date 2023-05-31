using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06weatherManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherManager weatherManager = new WeatherManager();


            double temp = weatherManager.GetTemperature("Berlin", "Celsius");
            Console.WriteLine(temp);
            double temp2 = weatherManager.GetTemperature("Berlin", "Fahrenheit");
            Console.WriteLine(temp2);

            Console.ReadKey();
        }
    }
}
