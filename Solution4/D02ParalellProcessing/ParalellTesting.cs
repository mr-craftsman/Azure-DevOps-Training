﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02ParalellProcessing
{
    internal class ParalellTesting
    {

        public void Task1()
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Task 1: {i}");

                Thread.Sleep(1000);
            }

        }
        public void Task2()
        {
            for (int i = 10; i < 15; i++)
            {
                Console.WriteLine($"Task 2: {i}");

                Thread.Sleep(1000); 
            }

        }
    }
}
