using System;

namespace Claculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter a number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter a number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write(num2 + num1);


            Console.ReadLine();

        }
    }
}
