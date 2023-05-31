using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EX04palindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Palindrome checker app");
            Console.WriteLine("Enter a word or phrase:");
            string input = Console.ReadLine();

            bool isPalindrome = IsPalindrome(input);

            Console.WriteLine(isPalindrome ? "It is a palindrome." : "It is not a palindrome.");

            Console.ReadKey();
        }
        static bool IsPalindrome(string input)
        {
            string cleanedInput = CleanString(input);
            string reversedInput = ReverseString(cleanedInput);

            return cleanedInput == reversedInput;
        }

        static string CleanString(string input)
        {
            string cleanedInput = Regex.Replace(input.ToLower(), @"[^a-z]", "");
            return cleanedInput;
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
