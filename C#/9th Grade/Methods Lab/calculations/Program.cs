using System;

namespace calculations
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double number = double.Parse(Console.ReadLine());
            double times = double.Parse(Console.ReadLine());
            Console.WriteLine(Times(number, times));

        }
        static double Times(double number, double times)
        {
            double result = 0;

            for(int i = 0; i <= times; i++)
            {
                result = Math.Pow(number, i);
            }

            return result;
        }
    }
}
