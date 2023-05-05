using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace B03___error_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            string s = "dog";

            try
            {
                double c = a / b;

                s.Substring(3, 1);
            }
            catch(DivideByZeroException ex)  //ex to provide variable to get information about this exception
            {
                Console.WriteLine("division by zero exception");
                File.AppendAllText(@"E:\weatherData\errors.txt", Environment.NewLine + ex.Message);
                
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("you have put the wrong index");
                File.AppendAllText(@"E:\weatherData\errors.txt", Environment.NewLine + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("some another exception happened");
                File.AppendAllText(@"E:\weatherData\errors.txt", Environment.NewLine + ex.Message);
            }
            Console.ReadKey();
            

        }
    }
}
