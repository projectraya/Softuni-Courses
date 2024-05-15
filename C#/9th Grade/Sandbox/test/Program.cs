using System;
using System.Linq;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());

            string input = Console.ReadLine(); //moje da e ili green ili car name
            Queue<char> carLetters = new Queue<char>();
            int count = 0;
            bool isDone = false;

            while(input != "END")
            {
                if(input == "green")
                {
                    carLetters.Clear();
                }
                else
                {
                    for(int i = 0; i < input.Length; i++)
                    {
                        carLetters.Enqueue(input[i]);
                    }
                    if(carLetters.Count < greenLightSeconds +freeWindowSeconds)
                    {
                        count++; //count za preminalite koli
                    }
                    else
                    {
                        int difference = carLetters.Count - greenLightSeconds;
                        char letter = ' ';
                        for(int j = 0; j < difference; j++)
                        {
                            letter = carLetters.Dequeue();
                        }
                        Console.WriteLine("Crash on the crossroad!");
                        Console.WriteLine($"{input} was hit at {letter}.");
                        isDone = true;
                        break;
                    }
                    
                    
                }
                
                input = Console.ReadLine();
            }
            if(isDone == false)
            {
                Console.WriteLine("No crash happened");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }
            

        }
    }
}
