using System;

namespace AdvancedArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
           
            for(int i =1; i<=n; i++)
            {
                if( n % i ==0)
                {
                  sum +=  n / i;
                }

            }


            Console.ReadLine();
        }
    }
}
