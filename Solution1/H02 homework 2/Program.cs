using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that asks the user for two integers and uses a conditional statement to display 
//the greater number.

namespace H02_homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a first number for comparison");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide a second number for comparison");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
                Console.WriteLine($"First number {number1} is greater than second number {number2}");
            else if (number1 < number2)
                Console.WriteLine($"First number {number1} is lower than second number {number2}");
            else if (number1 == number2)
                Console.WriteLine($"First number {number1} is equal to second number {number2}");
            else
                Console.WriteLine($"It seems you did not provided numbers");

            Console.ReadKey();

        }
    }
}
