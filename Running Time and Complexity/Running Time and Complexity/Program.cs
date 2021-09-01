using System;

namespace Running_Time_and_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            int[] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(PrimalityAlgorithm(nums[i]));
            }
            Console.ReadLine();
        }
        public static string PrimalityAlgorithm(int num)
        {
            if (num == 1)
                return "Not Prime";

            for (int i=2; i<=MathF.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return "Not Prime";
                }
            }
            return "Prime";
        }
    }
}
