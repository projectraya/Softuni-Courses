using System;

namespace vtora
{
    class Program
    {
        static void Main(string[] args)
        {
            int planks = int.Parse(Console.ReadLine());
            string length = Console.ReadLine();
            string delivery = Console.ReadLine();

            double price = 0.0; 
            double newPrice = 0.0; //ako ne stane vij tuk

            if(planks < 10) //ako ne stane vij tuk
            {
                Console.WriteLine("Boards can not be less than 10.");
                return;
            }

            if(length == "9mm")
            {
                price = 100;
                newPrice = price * planks;

                if(planks > 30 && planks <= 50)
                {
                    newPrice = newPrice - newPrice * 5 / 100; //ako ne stane vij tuk
                }else if(planks > 50)
                {
                    newPrice = newPrice - newPrice * 9 / 100;
                }
                
            }else if(length == "11mm")
            {
                price = 125;
                newPrice = price * planks; //ako ne stane vij tuk
                if (planks > 35 && planks <= 70)
                {
                    newPrice = newPrice - newPrice * 7 / 100;
                }
                else if (planks > 70)
                {
                    newPrice = newPrice - (newPrice * 10 / 100);
                }
            }
            else if(length == "15mm")
            {
                price = 185;
                newPrice = price * planks; //ako ne stane vij tuk
                if (planks > 25 && planks <= 60)
                {
                    newPrice = newPrice - newPrice * 8 / 100;
                }
                else if (planks > 60)
                {
                    newPrice = newPrice - newPrice * 15 / 100;
                }
            }
            else if(length == "18mm")
            {
                price = 210;
                newPrice = price * planks; //ako ne stane vij tuk
                if (planks > 35 && planks <= 55)
                {
                    newPrice = newPrice - newPrice * 10 / 100;
                }
                else if (planks > 55)
                {
                    newPrice = newPrice - newPrice * 15 / 100;
                }
            }

            

            if (delivery == "Delivery")
            {
                newPrice = newPrice + 50;
            }

            if(planks > 100)
            {
                double bonusPrice = newPrice - newPrice * 5 / 100;
                Console.WriteLine($"{bonusPrice:F2} BGN");
                return;
            }

            Console.WriteLine($"{newPrice:F2} BGN");
        }
    }
}
