using System;

namespace flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.00;
            
            

            if (flower == "Roses")
            {
                price = 5;
                if(count > 80)
                {
                    double final = price - price / 100 * 10;
                }
                else
                {
                    double final = price * count;
                }
            }
            else if(flower == "Dahlias")
            {
                price = 3.8;
                if (count > 90)
                {
                    double final  = price - price / 100 * 15;
                }
                else
                {
                    double final = price * count;
                }
            }
            else if (flower == "Tulips")
            {
                price = 2.8;
                if (count > 80)
                {
                    double final = price - price / 100 * 15;
                }
                else
                {
                    double final = price * count;
                }
            }
            else if (flower == "Narcissus")
            {
                price = 3;
                if (count < 120)
                {
                    double final = price = price / 100 * 15;
                }
                else
                {
                    double final = price * count;
                }
            }
            else if (flower == "Gladiolus")
            {
                price = 2.5;
                if (count < 80)
                {
                    double final = price + price / 100 * 25;
                }
                else
                {
                    double final = price * count;
                }
            }

            double finalPrice = price * count;
            if(finalPrice > budget)
            {
                double left = finalPrice - budget;
                
                Console.WriteLine("Not enough money, you need" + " " + left + ".00" + " " + "leva more.");
            }
            else
            {
                double left = budget - final;
                Console.WriteLine("Hey, you have a great garden with" + " "  + count + " " + flower + " " + "and" + " " + left + ".00" + " leva left.");
            };
        }
    }
}
