using System.Collections.Immutable;
using Wintellect.PowerCollections;

namespace Exam.Data_Structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ownerCompanies = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" | ").ToArray();
                string company = data[0];
                string owner = data[1];

                ownerCompanies.Add(company, owner);
            }
            ownerCompanies = ownerCompanies.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            
            string[] range = Console.ReadLine().Split(" - ").ToArray();
            char start = char.Parse(range[0].ToUpper());
            char end = char.Parse(range[1].ToUpper());

            foreach(KeyValuePair<string, string> pair in ownerCompanies)
            {
                if (pair.Value[0] >= start && pair.Value[0] < end)
                {
                    Console.WriteLine($"{pair.Value} - {pair.Key}");
                }
            }

        }
    }
}
