using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide two numbers, this is number one:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now number two:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sumNumber = number1 + number2;
            string sumNumberLen = (Convert.ToString(sumNumber));
            Console.WriteLine("Your number`s sum is: " + sumNumber + " And it has: " + sumNumberLen.Length +" characters");
            string report = $"the result of a sum of {number1} and {number2} is {sumNumber}";
            Console.WriteLine(report);
            string report2 = string.Format("The {0} total number has {1} characters", sumNumber, sumNumber);
            Console.WriteLine(report2);


            //part 2
            Console.WriteLine("Please provide 2 numbers separated by a spece");
            string twoNumbers = Console.ReadLine();

            int positionsNumbers = twoNumbers.IndexOf(" ");
            int numberOne = Convert.ToInt32((twoNumbers.Substring(0, positionsNumbers)));
            int numberTwo = Convert.ToInt32((twoNumbers.Substring(positionsNumbers + 1)));
            int sumNumbersEx2 = numberOne + numberTwo;
            // add sum of new numbers
            string reportEx2 = $"The result of a sum of {numberOne} and {numberTwo} is {sumNumbersEx2}";
            Console.WriteLine(reportEx2);



            Console.ReadKey();

        }
    }
}
