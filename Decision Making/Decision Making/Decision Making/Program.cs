using System;

namespace Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {

                


                for (int spacing = 9 -row ; spacing > 0 ; spacing--)
                {
                   
                    Console.Write(" ");
                }
                for (int column = 0; column < (2 * row + 1); column++)
                {
                   // Console.Write(" ");

                    Console.Write("*");

                }

                Console.WriteLine();
            



            }
                Console.ReadKey();

        }
    }
}
