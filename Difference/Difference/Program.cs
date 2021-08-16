using System;
using System.Linq;

namespace Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 5};
            Console.WriteLine("Hello World!");
            Difference dif = new Difference(array);
            dif.ComputeDifference();
            Console.ReadLine();
        }
    }

    public class Difference
    {
        private int[] elements;
        public int maximumDifference;



        public Difference(int[] myArray)
        {
            elements = myArray;
        }

        public void ComputeDifference()
        {
            for(int i=0; i<elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if (elements[i] - elements[j] > maximumDifference)
                        maximumDifference = elements[i] - elements[j];
                }
            }
            Console.WriteLine(maximumDifference);
        }
    }
}
