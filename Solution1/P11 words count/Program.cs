using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_words_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence, with words to count:");
            string userStatement = Console.ReadLine();
            Console.WriteLine("Please enter a word, you want to count:");
            string userWord = Console.ReadLine();
            int wordCount = 0;
            int sentenceIndex = 0;
            while (sentenceIndex <= userStatement.Length - userWord.Length)
            {
                string substringWord = userStatement.Substring(sentenceIndex, userWord.Length);
                if (substringWord == userWord)
                    wordCount++;
                    
                sentenceIndex++;    
            }
            string patternWord = "The word/char, {0}, occurs in sentence {1} times";
            Console.WriteLine(string.Format(patternWord,userWord, wordCount));
            Console.ReadKey();
        }
    }
}
