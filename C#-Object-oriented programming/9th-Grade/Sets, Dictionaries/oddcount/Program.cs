using System;
using System.Linq;
using System.Collections.Generic;

namespace oddcount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach(string word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            foreach(string word in counts.Keys)
            {
                int value = counts[word];
                if(value % 2 != 0 && value >= 1)
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}
