using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A06_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {   // basic operators
            int a = 1;
            bool isEqual = a == 1;
            a++;
            a += 4;

            a *= 3;
            a -= 6;
            a /= 2;

            bool isLess = a < 5;
            bool isGreatEq = a >= 5;

            bool orCondition = a < 5 || a > 10;
            bool andCondition = a > 5 && a < 10;
            bool isDifferent = !(a == 5);


        }
    }
}
