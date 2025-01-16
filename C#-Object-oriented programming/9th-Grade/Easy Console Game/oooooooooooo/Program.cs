using System;

namespace oooooooooooo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play a game?");
            Console.WriteLine("If yes, write your favorite number below:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number}, huh?");
            Console.WriteLine("I've seen better ones but alright, let's begin...");

            Console.WriteLine("Multiply your number by 2 (WITHOUT CALCULATOR) and then devide it with the answer of this ecuation...");
            Console.WriteLine("9*3 - 5^2");
            Console.WriteLine("Now if you did your calculations right, I can bet you got the exact number you started with, right? It's like magic!!!");
        }
    }
}
