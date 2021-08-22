using System;

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Yousef dude = new Yousef();
            dude.Height();
            dude.DefineReligion();
            dude.Race();
            Console.WriteLine(dude.Height()+
            dude.DefineReligion()+
            dude.Race());
            Console.ReadLine();

        }
        public static Person MakePerson()
        {
            Random rand = new Random();

            if (Math.Abs(rand.NextDouble()) % 2 == 0)
            {
                return new Yousef();
            }
            else
            {
                return null;
            }
        }
    }
}
