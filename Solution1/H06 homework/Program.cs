using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Create a program that uses loops to generate the Fibonacci sequence up to a given number 'n'.
namespace H06_homework
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a number, up to which a Fibonacci series will be printed:\n");
            int fibo_range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---Fibo sequence---");
            List<int> fibo_list = new List<int>();
            fibo_list.Add(0);
            fibo_list.Add(1);
            int nextItem = 0;
            for (int indx = 1; indx < fibo_range; indx++)
            {
                nextItem = 0;
                for (int i = indx; i > indx - 2; i--)
                {
                    nextItem += fibo_list[i];
                }
                fibo_list.Add(nextItem);
            }

            foreach (var fibo_item in fibo_list) 
            {
                Console.WriteLine(fibo_item);
            }
 
            Console.ReadKey();

        }
    }
}
