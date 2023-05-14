using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01___day_one_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n_number = 44;
            int even_sum = 0;
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
