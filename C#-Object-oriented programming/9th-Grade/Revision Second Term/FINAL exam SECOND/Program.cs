using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FINAL_exam_SECOND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pairsPattern = @"([@|#])([a-zA-Z]+)\1\1([a-zA-Z]+)\1";

            MatchCollection matches = Regex.Matches(text, pairsPattern);
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            foreach(Match pair in matches)
            {
                string first = pair.Groups[2].ToString();
                string second = pair.Groups[3].ToString();
                
                //reverse the second one

                second.Reverse();
                
                //check if they are the same
                if (first  == second)
                {
                    pairs.Add(first, second);
                }
            }

            Console.WriteLine($"{matches.Count} word pairs found!");
            if(pairs.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                foreach(KeyValuePair<string, string> pair in pairs)
                {
                    Console.Write($"{pair.Key} <=> {pair.Value}, ");
                }
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
            
        }
    }
}
