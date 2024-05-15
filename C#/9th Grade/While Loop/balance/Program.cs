using System;

namespace balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;

            while (input != "NoMoreMoney")
            {
                double sum = double.Parse(input);
                
                if(sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    balance += sum;
                    Console.WriteLine($"Increase: {sum:f2}");

                    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {balance:F2}");
            
        }
    }
}
