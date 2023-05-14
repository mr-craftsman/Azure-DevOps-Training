using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a program that uses a loop and a conditional statement
//to print all prime numbers between 1 and 100.
namespace H04_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            bool marker = true;
            //primes begin at 2
            Console.WriteLine("Prime numbers in range 1 to 100 are: ");
            for (int i = 2; i<=100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        marker = false;
                        break;
                    }
                }
                if (marker)
                {
                    Console.WriteLine("\t" + i);
                }
                marker = true;
            };
            Console.ReadKey();
        }
    }
}
