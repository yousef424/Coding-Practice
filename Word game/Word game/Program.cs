using System;

namespace Word_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;
            Console.Write("Enter a color ");
            color =  Console.ReadLine();
            Console.Write("Enter a pluralNoun ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity name ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are red");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();

        }
    }
}
