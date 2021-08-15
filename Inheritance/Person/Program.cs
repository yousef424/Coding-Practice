using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Person
{
    class Program
    {
		static void Main(string[] args)
		{
			int[] scores = new int[3] { 50, 50, 20 };
			Student dude = new Student("ahmed", "jack", 5, scores);

		    Console.WriteLine(dude.Claculate(scores));

			Console.ReadLine();
		}
	}
}
