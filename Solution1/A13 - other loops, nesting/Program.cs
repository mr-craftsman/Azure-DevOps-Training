using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13___other_loops__nesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userSentence = "Some things go along the every time it is done";

            int wordIndex = 0;


/*            while (wordIndex < userSentence.Length)
            {
                Console.WriteLine(userSentence.Substring(wordIndex, 1));
                wordIndex++;
            }*/

/*            do
            {
                Console.WriteLine(userSentence.Substring(wordIndex, 1));
                wordIndex++;
            } while (wordIndex < userSentence.Length);*/

            for (int i = 0; i < userSentence.Length; i++)
            {
                Console.WriteLine(userSentence.Substring(wordIndex, 1));
            }

/*            foreach (var item in collection)
            {

            }*/
        }
    }
}
