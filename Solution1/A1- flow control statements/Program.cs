using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1__flow_control_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            //while (a<10)
            //{
            //    a++;
            //    Console.WriteLine(a);
            //}

            string equationCheck = "1000 200"; //string with a space
            int index = 0;
            int spacePosition = -1; //just declaration of a variable
            while (index<equationCheck.Length)
            {
                if (equationCheck.Substring(index, 1) == " ")  // itarating through every index until ' '
                {
                    spacePosition = index;
                    break;
                }
                index++;    
                        
               
            }
            Console.WriteLine(index);


            Console.ReadKey();
        }
    }
}
