using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08_conditional_excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please provide an equation of 2 SINGLE-DIGIT numbers and oparator between");
            string userInput = Console.ReadLine();
            string userInputOperator = userInput.Substring(1,1);
            double number1 = Convert.ToDouble(userInput.Substring(0,1));
            double number2 = Convert.ToDouble(userInput.Substring(2,1));
            
            //int? result = null // ? helps with data types that are not 'nullable' type.

            switch (userInputOperator)
            {
                case "*":
                    Console.WriteLine($"The result of expression is {number1 * number2}");
                    break;
                case "/":
                    Console.WriteLine($"The result of expression is {number1 / number2}");
                    break;
                case "+":
                    Console.WriteLine($"The result of expression is {number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"The result of expression is {number1 - number2}");
                    break;


                default:
                    Console.WriteLine("It seems you wrote the expression wrong");
                    break;
            }
            Console.ReadKey();
        }
    }
}
