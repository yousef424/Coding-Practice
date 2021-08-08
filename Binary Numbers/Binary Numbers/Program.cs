using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        public static void DecimalToBinary(int n, Stack<int> nums)
        {
            int count = 0;
            int max = 0;
            int remainder = 0;

            while (n > 0)
            {
                remainder = n % 2;
                nums.Push(remainder);
                n = n / 2;
            }

            foreach (int num in nums)
            {


                Console.Write(num);
            }

            foreach (var num in nums)
            {
                if (num == 1)
                {
                    count++;
                    if (count > max)
                    {
                        max = count;

                    }
                }
                else
                {
                    count = 0;

                }
            }
            Console.WriteLine();
            Console.WriteLine(max);
            Console.ReadLine();
        }
        public static void BinaryToDecimal(string n)
        {

            int sum = 0;
            char[] myArray = n.ToCharArray();
            Array.Reverse(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == '1')
                {
                    // Method uses raising 2 to the power of the index. 
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }

            }

            Console.WriteLine(sum);
        }
    }
}

