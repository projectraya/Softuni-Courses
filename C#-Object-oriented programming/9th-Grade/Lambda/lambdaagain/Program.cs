using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace lambdaagain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            string command = Console.ReadLine();
            for(int i = numbers[0]; i < numbers[1]; i++)
            {
                Predicate<int[]> predicate  = num => numbers[i] % 2 == 0;
                if(predicate == true)
                {

                }
            }
            
            
        }
    }
}
