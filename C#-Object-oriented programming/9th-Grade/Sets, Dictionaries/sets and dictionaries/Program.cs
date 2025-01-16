using System;
using System.Linq;
using System.Collections.Generic;

namespace sets_and_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //8 2 2 8 2
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach(int key in numbers)
            {
                if (counts.ContainsKey(key))
                {
                    counts[key] = counts[key] + 1;
                }
                else
                {
                    counts.Add(key, 1);
                }
            }
            //nachin 1

            //foreach (KeyValuePair<double, int> pair in counts)
            //{
            //    Console.WriteLine($"{pair.Key} -> {pair.Value}");
            //}
            
            //nachin 2
            foreach(int key in counts.Keys)
            {
                int value = counts[key];
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
