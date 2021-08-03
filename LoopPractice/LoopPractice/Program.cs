using System;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());



            for(int i = 1; i <= 10; i++)
            {
                int result;
                result = i * num;
                Console.WriteLine( num + " X " + i + " = " + result);
            }
            Console.ReadKey();



        }
    }
}
