using System;

namespace vhodno
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceAbove10kg = double.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int pratki = int.Parse(Console.ReadLine());

            double newPrice = 0.0;
            
            if(kg < 5)
            {
                newPrice = priceAbove10kg * 20 / 100;
                
            }
            else if(kg >= 5 && kg <= 10)
            {
                newPrice = priceAbove10kg * 50 / 100;
            }
            else if (kg > 10)
            {
                newPrice = priceAbove10kg;
            }

            if(days > 7)
            {
                newPrice = newPrice + newPrice * 35 / 100;
            }
            else if(days >= 3 && days <= 7)
            {
                newPrice = newPrice + newPrice * 15 / 100;
            }
            else if(days < 3)
            {
                newPrice = newPrice + newPrice * 10 / 100;
            }

            double finalPrice = newPrice * pratki;
            Console.WriteLine($"The total price is: {finalPrice:F2} lv.");
        }
    }
}
