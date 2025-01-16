using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = "";
            MatchCollection matches = Regex.Matches(input, regex);
            List<Match> boughtItems = new List<Match>();
            double sum = 0;

            while(input != "Purchase")
            {
                foreach (Match match in matches)
                {
                    boughtItems.Add(match.Groups[1]);
                    sum += match.Groups[2];
                
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach(Match boughtItem in boughtItems)
            {
                Console.WriteLine(boughtItem);
            }
            Console.WriteLine("Total money spent:");
            Console.WriteLine(sum);

        }
    }
}
