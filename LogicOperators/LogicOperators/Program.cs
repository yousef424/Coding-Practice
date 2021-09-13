using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace LogicOperators
{
    class Logic
    {
        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < t; i++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int numbers = Convert.ToInt32(firstMultipleInput[0]);

                int K = Convert.ToInt32(firstMultipleInput[1]);

                int result = Logic.bitwiseAnd(numbers, K);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
        
        public static int bitwiseAnd(int N, int K)
        {
            int result = 0;
            int max = 0;
            for(int A = 1; A<=N; A++)
            {

                for (int B = A + 1; B <= N; B++)
                {
                    if (A < B)
                    {
                        max = A & B;
                    }
                    if(result < max && max < K)
                    {
                        result = max;
                    }
                }
            }
            return result;
        }
        
        public static int BinaryToDecimal(string n)
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
            return sum;
        }
        public static string DecimalToBinary(int n)
        {
            string binVal = Convert.ToString(n, 2);
            int bits = 0;
            int bitblock = 4;

            for (int i = 0; i < binVal.Length; i += bitblock)
            { 
                bits += bitblock; 
            }

            return binVal.PadLeft(bits, '0');
        }
    }
}
