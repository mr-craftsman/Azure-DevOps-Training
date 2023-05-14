using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            userName = userName.ToUpper();
            Console.WriteLine("Please eneter your age");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int userAgeInYear = userAge + 1;
            

            Console.WriteLine(userName);
            Console.WriteLine("UserAge in a year is" + userAgeInYear);
            Console.ReadKey();
        }
    }
}
