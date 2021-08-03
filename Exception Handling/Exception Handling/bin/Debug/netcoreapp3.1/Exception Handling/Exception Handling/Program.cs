using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            try
            {
                while (!repeat)
                {


                    Console.Write(" enter a number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" enter a number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num1 / num2);
                    Console.ReadLine();
                    repeat = true;
                }
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                repeat = false;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }



            Console.ReadLine();
           

        }
    }
}
