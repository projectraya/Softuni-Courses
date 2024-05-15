using System;

namespace tretaotnovo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            string currentName = " ";
            double currentPoints = 0.0;

            while(name != "END")
            {
                currentName = name;
                currentPoints = points;
                if(points > 626.5)
                {
                    break;
                }
                name = Console.ReadLine();
                if(name == "END")
                {
                    break;
                }
                points = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{currentName} is the best shooter!");
            if(currentPoints > 626.5)
            {
                Console.WriteLine($"{currentName} improve the national record with {currentPoints} scored points.");
            }
            else
            {
                Console.WriteLine($"Scored points: {currentPoints}");
            }
        }
    }
}
