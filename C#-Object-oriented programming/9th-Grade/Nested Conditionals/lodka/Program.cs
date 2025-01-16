using System;

namespace lodka
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishman = int.Parse(Console.ReadLine());
            double price = 0.00;
            switch (season)
            {
                case "Spring":
                    price = 3000; break;
                case "Summer":
                case "Autumn":
                    price = 4000; break;
                case "Winter":
                    price = 2600; break;
            }
            if(fishman <= 6)
            {
                price *= 0.9;
            }else if(fishman >= 7 && fishman <= 11){
                price *= 0.85;

            }
            else
            {
                price *= 0.75;
            };

            if(season != "Autumn" && fishman % 2 == 0)
            {
                price *= 0.95; 
            }
            if(budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva left.");
            }
        }
    }
}

