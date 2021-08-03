using System;

namespace _2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1,2},
                {3,5},
                {2,6}
            };

            int[,] myArray = new int[0, 0];
            
            Console.Write(numberGrid[1, 0]);
            Console.ReadLine();
        }
    }
}
