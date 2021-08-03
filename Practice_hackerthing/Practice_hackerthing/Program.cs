using System;

namespace Practice_hackerthing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            double d = 4.0;
            string Love = "HackerRank ";

            int inputI;
            double inputD;
            string inputS;

            inputI =int.Parse( Console.ReadLine());
            inputD = double.Parse(Console.ReadLine());
            inputS = Console.ReadLine();

            Console.WriteLine(i + inputI);
            Console.WriteLine( String.Format("{0:0.0}",d + inputD));
            Console.WriteLine(Love + inputS);

            Console.ReadKey();
            









            /*
            string inputString;
            inputString = Console.ReadLine();
            Console.WriteLine("Hello, World.");
            Console.WriteLine(inputString);
            Console.ReadKey();
            */
        }
    }
}
