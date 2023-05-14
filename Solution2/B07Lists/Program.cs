using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cityArray = { "tokio", "moscow", "chicago" }; // fixed length

            string sampleString = "tokio";
            char sampleChar = 'k';

            List<string> list = new List<string>();  

            List<string> list2 = null; // null list, unusable

            list.Add("new york");
            list.Add("calcutta");

            list.Insert(1, "poznan"); 

            string city1 = list[0];
            string city3 = list[list.Count - 1]; // last 

            list.RemoveAt(1);)
            list.Remove("paris"); // remove frist occurence 

            //list.RemoveAll()
        }
    }
}
