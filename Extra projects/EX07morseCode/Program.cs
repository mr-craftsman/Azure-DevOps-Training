using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07morseCode
{
    internal class Program
    {

        // generate a dictionary
        static Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>()
    {
        {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."}, {'G', "--."},
        {'H', "...."}, {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."},
        {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"}, {'U', "..-"},
        {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"}, {'Z', "--.."}, {'0', "-----"},
        {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."},
        {'7', "--..."}, {'8', "---.."}, {'9', "----."}
    };
        static void Main(string[] args)
        {
            Console.WriteLine("Tthe Morse Code Translator");

            Console.Write("Enter '1' to translate text to Morse code, or '2' to translate Morse code to text: \n");
            string choice = Console.ReadLine();
            // choice of working method
            if (choice == "1")
            {
                Console.Write("Enter the text to translate to Morse code: ");
                string text = Console.ReadLine().ToUpper();

                string morseCode = TranslateToMorseCode(text);
                Console.WriteLine("Morse code: " + morseCode);
            }
            else if (choice == "2")
            {
                Console.Write("Enter the Morse code to translate to text (separate letters with space and words with '/'): ");
                string morseCode = Console.ReadLine();

                string text = TranslateToText(morseCode);
                Console.WriteLine("Text: " + text);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // main translator to morse code
        static string TranslateToMorseCode(string text)
        {
            string morseCode = "";
            foreach (char c in text)
            {
                if (morseCodeDictionary.ContainsKey(c))
                    morseCode += morseCodeDictionary[c] + " ";
                else if (c == ' ')
                    morseCode += "/ ";
                else
                    morseCode += c + " ";
            }
            return morseCode.Trim();
        }

        // translator to text from morse
        static string TranslateToText(string morseCode)
        {
            string[] morseCodeWords = morseCode.Split(new[] { " / " }, StringSplitOptions.None);
            string text = "";
            foreach (string morseCodeWord in morseCodeWords)
            {
                string[] morseCodeLetters = morseCodeWord.Split(' ');
                foreach (string morseCodeLetter in morseCodeLetters)
                {
                    foreach (KeyValuePair<char, string> kvp in morseCodeDictionary)
                    {
                        if (kvp.Value == morseCodeLetter)
                        {
                            text += kvp.Key;
                            break;
                        }
                    }
                }
                text += " ";
            }
            return text.Trim();
        }
    }
}
