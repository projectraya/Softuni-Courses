using System;
using System.Linq;
using System.Collections.Generic;

namespace listsexcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while(input != "end")
            {
                List<string> command = input.Split().ToList();
                if(command[0] == "Add")
                {
                    int current = int.Parse(command[1]);
                    numbers.Add(current);
                }
                else
                {
                    
                    for(int i = 0; i < numbers.Count; i++)
                    {
                        int current = int.Parse(command[0]);
                        int number = numbers[i];
                        if(number + current <= maxCapacity)
                        {
                            number += current;
                            numbers[i] = number;
                            break;
                        }
                        
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
