using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07_conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter your heigth:");

            int userHeigth = Convert.ToInt32(Console.ReadLine());

            bool condition1 = userHeigth > 180;
            if (condition1)
            {
                Console.WriteLine("you are so high");
            }
            else
            {
                Console.WriteLine("you are shorter");
            }

            if (userHeigth < 160)  // on just one instruction no brackets
                Console.WriteLine("shorty");
            else if(userHeigth > 180)
                Console.WriteLine("tally");
            else
                Console.WriteLine("average");

            string report;

            if (userHeigth < 160)  // on just one instruction no brackets
                report = "short";
            else if (userHeigth > 180)
                report = "tall";
            else
                report = "average";

            report = $"your height is {userHeigth} and it`s {report}";

             
            // ternary
            string result = userHeigth > 180 ? "tall" : "short";
        }   
    }
}
