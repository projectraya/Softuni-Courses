using System;
using System.Collections.Generic;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> mineralsCount = new SortedDictionary<string, int>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string elementType = input[0];
                string elementName = input[1];

                if(elementType == "mineral")
                {
                    if (!mineralsCount.ContainsKey(elementName))
                    {
                        mineralsCount[elementName] = 1;
                    }
                    else
                    {
                        mineralsCount[elementName]++;
                    }
                    
                }
            }

            foreach(KeyValuePair<string, int> pair in mineralsCount)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
