using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace string_and_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(?<separator>[#|])(?<item>[A-Za-z ]+)\k<separator>(?<date>\d{2}\/\d{2}\/\d{2})\k<separator>(?<cals>\d+)\k<separator>";

            MatchCollection matches = Regex.Matches(text, pattern);
            int allCals = 0;

            foreach(Match match in matches)
            {
                allCals += int.Parse(match.Groups["cals"].Value);
            }
            Console.WriteLine($"You have food to last you for: {allCals/2000} days!");

            foreach (Match match in matches)
            {
                string item = match.Groups["item"].Value;
                string date = match.Groups["date"].Value;
                string cals = match.Groups["cals"].Value;

                Console.WriteLine($"Item: {item}, Best before: {date}, Nutrition: {cals}");
            }
        }
            
        
    }
}
