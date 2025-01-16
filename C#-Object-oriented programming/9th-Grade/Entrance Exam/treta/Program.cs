using System;

namespace treta
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());

            string actual = name;
            while (name != "END" || points > 626.5)
            {
                name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                if (name != "END")
                {
                    points = double.Parse(Console.ReadLine());
                }


            }
            Console.WriteLine($"{actual} is the best shooter!");

            if (points > 626.5)
            {

                Console.WriteLine($"{actual} improve the national record with {points} scored points.");
            }
            else
            {
                Console.WriteLine($"Scored points: {points}");
            }

        }
    }
}
