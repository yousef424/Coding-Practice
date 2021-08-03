using System;

namespace Static_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song killme = new Song("killme", "me", 200);
            Song mamaya = new Song("mamaya", "you", 500);
           
            Console.WriteLine(Song.songCount);
            Console.WriteLine(killme.getSongCount());
           
            Console.ReadLine();

        }
    }
}
