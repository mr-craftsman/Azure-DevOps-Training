using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B04Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city1 = "Paris";
            string city2 = "Cracow";
            string city3 = "Tokio";

            string[] cities = new string[4];

            cities[0] = city1;
            cities[1] = city2;
            cities[3] = "Frankfurt";

            cities[1] = "Berlin";

            // cities[4] = "Moscow"; // index out of range

            int arrayLength = cities.Length;

            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[3]);


            int[] numbers = new int[2];
            Console.WriteLine(numbers[0]);

            bool[] boolArray = new bool[2];


            int?[] numbers1 = new int?[2];

            int[] numbers2 = new int[3] { 4, 5, 7 };


            int[] numbers3 = { 4, 5, 7 };

            bool?[] boolArray2 = { true, false, true };

            char[] characters = { 'a', 'b', 'c' };



            Console.ReadKey();
        }
    }
}
