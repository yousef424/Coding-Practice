using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = 6;

            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index <= 5);

            Console.ReadLine();
        }
    }
}
