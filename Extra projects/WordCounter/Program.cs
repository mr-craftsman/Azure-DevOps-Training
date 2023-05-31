using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the WordCountApp\n" +
                "Please enter the folder with txt files:\n");
            string folderPath = Console.ReadLine();
            int totalWordCount = 0;

            string[] files = Directory.GetFiles(folderPath, "*.txt");

            int countWordsInFile(string filePath)
            {
                int wordCount = 0;
                string allText = File.ReadAllText(filePath);
                string[] words = allText.Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
                wordCount = words.Length;
                return wordCount;
            }

            foreach (string file in files) 
            {
                int localWordCount = countWordsInFile(file);
                totalWordCount += localWordCount;
                Console.WriteLine($"In a file: {Path.GetFileName(file)}, there are: {localWordCount} words");
            }
            Console.WriteLine($"There are total {totalWordCount} Words in all files" );
            Console.ReadKey();
        }
    }
}
