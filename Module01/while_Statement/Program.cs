﻿using System;

namespace while_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTest();
        }

        private static void WhileTest()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }
        }
    }
}
