using System;

namespace dowhile_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTest();
            DoWhileTest();
        }

        private static void DoWhileTest()
        {
            int i = 10;
            do
            {
                Console.WriteLine("Do While Test : The value of i is {0}", i);
                i++;
            } 
            while (i <= 5);
        }

        private static void WhileTest()
        {
            int i = 10;
            while (i <= 5)
            {
                Console.WriteLine("While Test : The value of i is {0}", i);
                i++;
            }
        }
    }
}
