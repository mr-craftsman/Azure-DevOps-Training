using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05_debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // some debugging
            string a1 = "a";
            string a2 = a1.ToUpper();

            int b1 = 3;
            int b2 = b1 + 1;
            Console.WriteLine(b2);

            string c = b1 + b2;

            Console.ReadKey();

        }
    }
}
