using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create an empty dictionary
        Dictionary<string, int> counts = new Dictionary<string, int>();

        // read a line of input from the console
        string input = Console.ReadLine();

        // split the input into words and add them to the dictionary
        string[] words = input.Split();
        foreach (string word in words)
        {
            if (counts.ContainsKey(word))
            {
                counts[word]++;
            }
            else
            {
                counts.Add(word, 1);
            }
        }

        // print the contents of the dictionary to the console
        foreach (KeyValuePair<string, int> pair in counts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}