using System;

namespace MyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBook mb = new MyBook("The Alchemist", "Paulo Coelho", 248);
            mb.Display();
            Console.ReadLine();
        }
    }
}
