using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(GetDay(num));
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName = null;

            switch(dayNum)
            {
                case 0:
                    dayName = "Saturday";
                    break;

                case 1:
                    dayName = "Sunday";
                    break;

                case 2:
                    dayName = "Monday";
                    break;

                case 3:
                    dayName = "Tuesday";
                    break;

                case 4:
                    dayName = "Wednesday";
                    break;

                case 5:
                    dayName = "Thursday";
                    break;

                case 6:
                    dayName = "Friday";
                    break;

                default:
                    dayName = "Invalid";
                    break;
            }

            return dayName; 
        }
    }
}
