 using System;

namespace Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {


              Movie inception = new Movie("inception", "eloy", "DOG");
              Movie shrek = new Movie("shrek", "wowosers", "G");

            Console.WriteLine(inception.Rating);



            Console.ReadLine();
        }
    }
}
