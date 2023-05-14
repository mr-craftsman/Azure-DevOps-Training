using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B06stringArraysConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // split
            string sentence = "Wie gehen Sie";

            string[] words = sentence.Split(' ');

            string sentence2 = "May we j!$n **for";

            string[] separators = { "!$", "**" };

            string[] words2 = sentence2.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // join

            string[] array = { "London", "Moscow", "Tokio" };

            string result = string.Join(" - ", array);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
