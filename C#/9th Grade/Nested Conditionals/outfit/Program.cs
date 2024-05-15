using System;

namespace outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            

            if(degrees >= 10 && degrees <= 18)
            {
                if(time == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                }
                else if(time == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if(time == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                };
            }else if(degrees > 18 && degrees <= 24)
            {
                if (time == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (time == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (time == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                };
            }
            else if(degrees >= 25)
            {
                if (time == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (time == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Swimsuit and Barefoot.");
                }
                else if (time == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                };
            };
        }
    }
}
