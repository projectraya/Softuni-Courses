using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if(num >= 1 && num % 5 == 0)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}
