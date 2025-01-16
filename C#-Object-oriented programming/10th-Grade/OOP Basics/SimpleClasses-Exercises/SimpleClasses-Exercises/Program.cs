using System;

namespace SimpleClasses_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateCounter counter = new DateCounter();

            Console.WriteLine(counter.Calculate(date1, date2));
        }
    }
}
