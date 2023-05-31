using C10Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 10;

            Programmer programmer = new Programmer();
            programmer.Name = "John";
            programmer.Address = "Main street ";
            programmer.Age = 10;


        }
    }
}
