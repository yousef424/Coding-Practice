using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = 6;
            int colSize = 6;
            int sum = -10;
            int currentsum = 0;
            int count = 0;
            int[,] myArray = new int[rowSize, colSize];


            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    myArray[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }









            for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                            currentsum = myArray[i, j] + myArray[i, j + 1] + myArray[i, j + 2] + myArray[i + 1, j + 1] + myArray[i + 2, j] + myArray[i + 2, j + 1] + myArray[i + 2, j + 2];


                             if (sum < currentsum)
                             {
                               sum = currentsum;
                             }
                         
                    }
                }            
            Console.WriteLine(sum);
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
