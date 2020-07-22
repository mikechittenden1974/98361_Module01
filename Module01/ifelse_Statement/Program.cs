using System;

namespace ifelse_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIfElse(10);
        }
        
        public static void TestIfElse(int n)
        {
            if (n <= 10)
            {
                Console.WriteLine("n is less than, or equal to 10");
            }
            else if (n <= 20)
            {
                Console.WriteLine("n is less, or equal to 20");
            }
            else if (n <= 30)
            {
                Console.WriteLine("n is less, or equal to 30");
            }
            else
            {
                Console.WriteLine("n is greater than, or equal, to 30");
            }
        }
    }
}
