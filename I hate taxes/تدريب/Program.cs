using System;

namespace تدريب
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCost = 1f;
            double tax = 1f;
            double tip = 1f;
            tip = (12.0 / 100.0) * 20.0;
            tax = (8.0 / 100.0) * 20.0;
            totalCost = 12.25 + tip + tax;
            Math.Round(totalCost,15);
            Console.WriteLine(tip);
            Console.WriteLine(tax);
            Console.WriteLine(totalCost);
            Console.ReadKey();
            Convert.ToInt32(totalCost);
        }

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double totalCost;
            double tax;
            double tip;
            tip = meal_cost * tip_percent / 100;
            tax = meal_cost * tax_percent / 100;
            totalCost = meal_cost + tip + tax;
            MathF.Round((float)totalCost, 1);
           
            string.Format("{0:0.##}", totalCost);
            Console.WriteLine((int)totalCost);
        }
    }
}
