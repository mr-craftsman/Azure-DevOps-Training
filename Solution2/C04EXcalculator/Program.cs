using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04EXcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double? result1 = calculator.PerformOperation("88-77");

            double? result2 = calculator.PerformOperation(4, 5, '+');

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
