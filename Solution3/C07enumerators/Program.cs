using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using C06weatherManager;
using C07enumerators;

namespace C06weatherManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a city");
            string city = Console.ReadLine();

            List<Unit> units = Enum.GetValues(typeof(Unit)).Cast<Unit>().ToList();

            Console.WriteLine("Enter a unit: " +
                string.Join(", ", units));

            string unit = Console.ReadLine();

            bool isVaild = Enum.TryParse(unit, out Unit unitEnum);

            Unit selectedUnit = (Unit)Enum.ToObject(typeof(Unit), 2 - 1);

            if (isVaild)
            {
                WeatherManager weatherManager = new WeatherManager();
                double temp = weatherManager.GetTemperature(city, unitEnum);
                Console.WriteLine(temp);
            }

            //weatherManager.GetTemperature("Berlin", Unit.Kelvin);
        }
    }
}
