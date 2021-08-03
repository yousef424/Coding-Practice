 using System;

namespace Better_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number buddy: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("whatcha wanna do ");
            string op = Console.ReadLine();

            Console.Write("enter a number buddy: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("invalid operator");
            }

            Console.ReadLine();
        }
    }
}
