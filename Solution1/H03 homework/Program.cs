using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that initializes a list of 10
//numbers and uses a loop to calculate the average of the numbers.

namespace H03_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers_array = new int[] { 13, 22, 45, 534, 26, 62367, 52, 255, 25, 75 };
            int sum_in_array = 0;
            foreach (var number in numbers_array)
            {
                sum_in_array += number;
            }
            int result = sum_in_array/numbers_array.Length;
            string raport = $"The array has average value of {result}.";
            Console.WriteLine(raport);
            Console.ReadKey();

        }
    }
}
