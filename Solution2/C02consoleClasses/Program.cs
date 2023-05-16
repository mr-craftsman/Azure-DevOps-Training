using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02consoleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Calculator c = new Calculator(); // variable with reference

            Calculator c1; // unreferenced variable                        

            new Calculator(); // rarely used structore

            Calculator c2; // declaring without assignment

            c2 = new Calculator(); // assignment

            int g = c.CalculateSum(3, 4);
            int g2 = c.CalculateDifference(4, 3);

            Console.WriteLine(g);
            Console.WriteLine(g2);

            Console.ReadKey();
        }
    }
}
