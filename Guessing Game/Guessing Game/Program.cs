using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "what";
            string guess = "";
            int guessNum = 3;
            int guessLimit;
            bool right = false;

            do
            {
                Console.Write("Try guessing kid ");

                guess = Console.ReadLine();

                if (guess == secretWord)
                {
                    right = true;
                }


                guessNum--;
            }
            while (guess != secretWord && guessNum > 0 && !right);



            if (!right)
            {
                Console.Write("u suck");
            }
            else

            Console.Write("hey good stuff");
            
            Console.ReadLine();
        }
    }
}
