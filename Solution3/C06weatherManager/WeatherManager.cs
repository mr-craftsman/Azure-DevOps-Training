﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C06weatherManager
{
    internal class WeatherManager
    {
        public double GetTemperature(string city, string unit)
        {

            string searchChar = "°";
            string endChar = ">";


            //  Console.WriteLine("Enter the city name");
            //  string city = Console.ReadLine();

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
                // Console.WriteLine(result);
                return TransformTemperature(unit,
                    Convert.ToDouble(result.Substring(0, result.Length - 2)));
            }
            catch (Exception)
            {
                throw new Exception("Could not get temperature");
            }
        }


        public double TransformTemperature(string unit, double temperature)
        {
            if (unit == "Celsius")
                return temperature;

            if (unit == "Fahrenheit")
                return (temperature * 1.8) + 32;

            if (unit == "Kelvin")
                return temperature + 273.15;

            throw new Exception("Unknown unit");
        }
    }
}
