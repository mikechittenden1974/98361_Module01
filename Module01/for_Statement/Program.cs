using System;

namespace for_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ForTest();
        }

        private static void ForTest()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }
        }
    }
}
