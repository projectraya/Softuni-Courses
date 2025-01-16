using System;

namespace nested_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string projections = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double result = 0.00;

            switch (projections)
            {

                case "Premiere":
                    result = r * c * 12.00;
                    
                    Console.WriteLine("{0:F2}"); break;

                case "Normal":
                    result = r * c * 7.5;
                    Console.WriteLine($"{result} leva"); break;

                case "Discount":
                    result = r * c * 5.00;
                    Console.WriteLine($"{result} leva"); break;
            }



        }
    }
}
