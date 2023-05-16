using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C01variableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            char b = 'a';
            string c = "Hello";
            double d = 5.6;
            bool e = false;

            // in c# we have 2 data types : classes and structures 

            WebClient wc = new WebClient();
            StringBuilder sb = new StringBuilder("very long string");

            // classes - reference types ( reference )
            // structures - value types  ( copy ) 

            int a1 = a;  // copy of 6 

            StringBuilder sb2 = sb; // not a new object but only reference assignment

            DateTime dt = new DateTime(2023, 5, 5);
            DateTime dt2 = dt; // copy 
        }
    }
}
