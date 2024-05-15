using System;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            double deposit = double.Parse(Console.ReadLine());
            int deadline = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            Console.WriteLine(deposit + deadline * ((deposit / 100 * percent) / 12));


        }

    }
}

