using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_String_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "lazy dog example string is not that good";
            int stringLen = sentence.Length;
            string s1 = sentence.Substring(8);
            string s2 = sentence.Substring(4, 5); // from index to characters
            bool b1 = sentence.Contains("dog");
            string lowerCaseEx = sentence.ToLower();
            string upperCaseEx = sentence.ToUpper();
            string concatThis = "dog" + "cat" + "mouse";
            string concatTwo = sentence + "this too";
            string replaceTwo = sentence.Replace("dog", "cat");
            int showPosition = sentence.IndexOf("dog");


            // comment this
            Console.WriteLine(stringLen);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(b1);
            Console.ReadKey();

            
        }
    }
}
