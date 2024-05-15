using System;
using System.Linq;

namespace edinaista
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            
            for(int i = 0; i < numbers.Length; i++)
            {
                double final = numbers[i] / 2;
                Console.Write(final + " ");
            }
        }
    }
}
