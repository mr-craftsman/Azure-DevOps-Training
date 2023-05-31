using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Inheritance
{
    internal class Doctor : Person
    {
        public string Specialization { get; set; }

        public void Diagnose()
        {
            Console.WriteLine("Im diagnosing a patinet");
        }
    }
}