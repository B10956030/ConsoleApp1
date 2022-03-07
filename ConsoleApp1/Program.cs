using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            Console.Write("meal cost + tip percent + tax percent = ");
            Console.WriteLine(meal_cost + tip_percent + tax_percent);
        }
    }
}
