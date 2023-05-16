using C10Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Inheritance
{
    internal class Programmer : Person
    {
        public string ProgrammingLanguage { get; set; }



        public void Code()
        {
            Console.WriteLine("Im coding with " + ProgrammingLanguage);
        }

        public int Caclulate()
        {
            return 0;
        }
    }
}
