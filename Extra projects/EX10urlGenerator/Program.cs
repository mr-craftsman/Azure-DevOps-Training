using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10urlGenerator
{
    internal class Program
    {
        static Dictionary<string, string> urlDictionary;

        static void Main()
        {
            urlDictionary = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("This is an URL shortener app:");
                Console.WriteLine("1. shorten your URL with Base64 algorithm");
                Console.WriteLine("2. translate short URL back to full URL");
                Console.WriteLine("3. exit program");
                Console.Write("enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShortenURL();
                        break;
                    case 2:
                        DeCodeBack();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("wrong choice. try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ShortenURL()
        {
            Console.Write("enter URL to shorten: ");
            string url = Console.ReadLine();

            string shortCode = GenerateShortCode();
            urlDictionary.Add(shortCode, url);

            Console.WriteLine("shortened URL: " + shortCode);
        }

        static void DeCodeBack()
        {
            Console.Write("enter short URL to expand: ");
            string shortCode = Console.ReadLine();

            if (urlDictionary.ContainsKey(shortCode))
            {
                string originalURL = urlDictionary[shortCode];
                Console.WriteLine("decoded URL: " + originalURL);
            }
            else
            {
                Console.WriteLine("wrong short URL. URL can't be decoded.");
            }
        }

        static string GenerateShortCode()
        {
            // using Base64 encoding to shorten and decode URL
            byte[] bytes = Guid.NewGuid().ToByteArray();
            return Convert.ToBase64String(bytes)
                .Replace("/", "_")
                .Replace("+", "-")
                .Substring(0, 8); // Use only the first 8 characters
        }
    }
}
