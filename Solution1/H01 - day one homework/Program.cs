using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that initializes a variable 'n' with a positive integer and prints the
//sum of all even numbers from 1 to 'n' using a loop.
namespace H01___day_one_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n_number = 0;
            int even_sum = 0;
            Console.WriteLine("Please provide a number, a positive integer:\n");
            n_number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n_number; i++)
            {
                if (i % 2 == 0)
                    even_sum += i;
            }
            Console.WriteLine($"The sum of even numbers up to {n_number} is {even_sum}");
            Console.ReadKey();
        }
    }
}
