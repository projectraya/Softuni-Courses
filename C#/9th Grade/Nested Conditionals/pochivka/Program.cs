using System;

namespace pochivka
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double finalBudget = 0.00;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if(season == "summer")
                {
                    finalBudget = budget / 100 * 30;
                    Console.WriteLine($"Camp - {finalBudget:F2}");
                }
                else if(season == "winter")
                {
                    finalBudget = budget / 100 * 70;
                    Console.WriteLine($"Hotel - {finalBudget:F2}");
                };
                

            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    finalBudget = budget / 100 * 40;
                    Console.WriteLine($"Camp - {finalBudget:F2}");
                }
                else if (season == "winter")
                {
                    finalBudget = budget / 100 * 80;
                    Console.WriteLine($"Hotel - {finalBudget:F2}");
                };
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                if (season == "summer")
                {
                    finalBudget = budget / 100 * 90;
                    Console.WriteLine($"Hotel - {finalBudget:F2}");
                }
                else if (season == "winter")
                {
                    finalBudget = budget / 100 * 90;
                    Console.WriteLine($"Hotel - {finalBudget:F2}");
                };
            }
        }
    }
}
