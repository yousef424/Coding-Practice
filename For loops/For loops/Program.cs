using System;

namespace For_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 5, 6, 78, 98, 54 };

            for(int i = 0; i<luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);

            }
            Console.ReadLine();
        }
    }
}
