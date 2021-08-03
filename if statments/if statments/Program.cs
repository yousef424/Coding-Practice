using System;

namespace if_statments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(GetMax(10, 10));
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            int result = 0;

             if(num1 > num2 )
             {
                result = num1;
             }
             else if (num2 > num1)
             {
                result = num2;
             }

            return result;
        }
    }
}
