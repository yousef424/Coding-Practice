using System;

namespace Let_s_review
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
           


            for (int i = 0; i<T; i++)
            {
                string mystring = Console.ReadLine();
                char[] word = mystring.ToCharArray();

                for (int j = 0; j < word.Length; j+=2)
                {
                    Console.Write(word[j]);
                    
                }
                Console.Write(" ");

                for (int x = 1; x < word.Length; x+=2)
                {
                   Console.Write(word[x]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
