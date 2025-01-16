using System.Collections.Generic;
using System;
using System.Linq;

namespace dictionaryagain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, List<string>>> dictionary = 
                new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());
            

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dictionary.ContainsKey(continent))
                {
                    dictionary[continent] = new Dictionary<string, List<string>>();
                }
                if (!dictionary[continent].ContainsKey(country))
                {
                    dictionary[continent][country] = new List<string>();
                }
                dictionary[continent][country].Add(city);
                
            }


            foreach (KeyValuePair<string, Dictionary<string, List<string>>> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key}:");

                foreach (KeyValuePair<string, List<string>> countryCity in pair.Value)
                {
                    Console.WriteLine($" {countryCity.Key} -> {string.Join(", ", countryCity.Value)}");
                }

            }
        }
    }
}
