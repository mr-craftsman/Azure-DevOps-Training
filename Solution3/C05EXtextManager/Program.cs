using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EXtextManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a = "Jan";
            int b = 4;

            var c = "Jan";
            var d = 5;

            //  c = 5; // not a dynamic type

            var stringBuilders = new List<List<StringBuilder>>();

            dynamic e = 5;
            e = "Jan";

        }
    }
}
