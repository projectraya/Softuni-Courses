using System;
using System.Linq;
using System.Collections.Generic;

namespace gosho
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (IsValid(input))
            {
                Console.WriteLine($"Hello, {input}!");
                for(int j = 0; j < input.Length; j++)
                {
                    int current = input[j] + 10;
                    Console.WriteLine(current);
                }
            }
            else
            {
                Console.WriteLine("Invalid name!");
            }
        }
        
        static bool IsValid(string name)
        {
            if(name.Length < 3)
            {
                return false;
            }
            else if(name[0] < 'A' || name[0] > 'Z')
            {
                return false;
            }
        
            for(int i = 0; i < name.Length; i++)
            {
                if(name[i] >= '0' && name[i] <= '9')
                {
                    return false;
                }
            }
            return true;
        }

    }
    
}
