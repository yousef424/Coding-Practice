using System;

namespace Method_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(5));
            Console.ReadLine();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("hey dude" + name);
        }
        static void What()
        {
            Console.WriteLine("wowsers");
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
