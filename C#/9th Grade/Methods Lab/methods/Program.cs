using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintSignOf(grade);

        }
        static void PrintSignOf(double n)
        {
            if(n >= 2.0 && n < 3.0)
            {
                Console.WriteLine("Fail");
            }else if(n >= 3.0 && n < 3.5)
            {
                Console.WriteLine("Poor");
            }else if(n >= 3.5 && n < 4.5)
            {
                Console.WriteLine("Good");
            }
            else if (n >= 4.5 && n < 5.5)
            {
                Console.WriteLine("Very good");
            }
            else if (n >= 5.5 && n < 6.0)
            {
                Console.WriteLine("Excellent");
            }
        }
        
    }
}
