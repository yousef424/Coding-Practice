using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
            Console.ReadLine();

        }

        public static int Factorial(int n)
        {
            if(n <= 1 )
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }    

        }
    }
}
