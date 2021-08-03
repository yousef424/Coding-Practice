using System;

namespace Another_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if( n % 2 > 0)
            {
                Console.WriteLine("weird");
            }
            else if( n % 2 == 0 && n >=2 && n<=5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (n % 2 == 0 && n >= 6 && n <= 20)
            {
                Console.WriteLine("weird");
            }
            else if (n % 2 == 0 && n > 20)
            {
                Console.WriteLine("weird");
            }
            Console.ReadLine();
        }
    }
}
