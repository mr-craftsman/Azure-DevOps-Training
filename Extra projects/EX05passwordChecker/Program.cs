using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05passwordChecker
{

    static class StringExtensions
    {
        public static bool ContainsAny(this string str, string characters)
        {
            foreach (char c in characters)
            {
                if (str.Contains(c))
                    return true;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the password strength checker app.");
            Console.WriteLine("Enter a password to check:");
            string password = Console.ReadLine();

            int strengthScore = EvaluatePasswordStrength(password);
            string strengthSuggestions = GetStrengthSuggestions(strengthScore, password);

            Console.WriteLine($"Password strength score: {strengthScore}");
            Console.WriteLine(strengthSuggestions);

            Console.ReadKey();
        }
        static int EvaluatePasswordStrength(string password)
        {
            int score = 0;

            // check pass length
            if (password.Length >= 8)
                score += 3;
            else if (password.Length >= 6)
                score += 1;

            // check for special characters
            if (ContainsSpecialCharacters(password))
                score += 1;

            // check for numbers
            if (ContainsNumbers(password))
                score += 1;

            // check for uppercase and lowercase letters
            if (ContainsUppercaseLetters(password) && ContainsLowercaseLetters(password))
                score += 1;

            return score;
        }
        static bool ContainsSpecialCharacters(string password)
        {
            return !string.IsNullOrEmpty(password) && password.ContainsAny("!@#$%^&*()-_=+[]{};:'\"\\|,.<>/?");
        }

        static bool ContainsNumbers(string password)
        {
            return !string.IsNullOrEmpty(password) && password.ContainsAny("0123456789");
        }

        static bool ContainsUppercaseLetters(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Any(char.IsUpper);
        }

        static bool ContainsLowercaseLetters(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Any(char.IsLower);
        }

        static string GetStrengthSuggestions(int strengthScore, string password)
        {
            string suggestions = "Suggestions for improving the password's strength:\n";

            if (strengthScore < 4)
            {
                if (password.Length < 8)
                    suggestions += "- Use a longer password.\n";

                if (!ContainsSpecialCharacters(password))
                    suggestions += "- Include special characters such as !@#$%^&*().\n";

                if (!ContainsNumbers(password))
                    suggestions += "- Include numbers.\n";

                if (!ContainsUppercaseLetters(password) || !ContainsLowercaseLetters(password))
                    suggestions += "- Use a combination of uppercase and lowercase letters.\n";
            }
            else if (strengthScore < 6)
            {
                if (!ContainsSpecialCharacters(password))
                    suggestions += "- Include special characters such as !@#$%^&*().\n";

                if (!ContainsNumbers(password))
                    suggestions += "- Include numbers.\n";

                if (!ContainsUppercaseLetters(password) || !ContainsLowercaseLetters(password))
                    suggestions += "- Use a combination of uppercase and lowercase letters.\n";
            }
            else if (strengthScore < 8)
            {
                if (!ContainsSpecialCharacters(password))
                    suggestions += "- Include special characters such as !@#$%^&*().\n";

                if (!ContainsNumbers(password))
                    suggestions += "- Include numbers.\n";
            }

            return suggestions;
        }


    }
}
