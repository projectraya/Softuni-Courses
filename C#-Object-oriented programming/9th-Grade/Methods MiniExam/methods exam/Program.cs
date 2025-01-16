using System;

namespace methods_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{CalculatePrice(food, quantity):F2}");
        }
        static double CalculatePrice(string food, int quantity)
        {
            double price = 0.0;
            if(food == "water")
            {
                price = quantity * 1.0;
            }
            else if(food == "coke")
            {
                price = quantity * 1.4;
            }
            else if(food == "coffee")
            {
                price = quantity * 1.5;
            }
            else if(food == "snacks")
            {
                price = quantity * 2.0;
            }
            return price;
        }
    }
}
