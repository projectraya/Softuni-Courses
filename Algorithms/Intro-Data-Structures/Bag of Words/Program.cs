using Wintellect.PowerCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Bag_of_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            OrderedBag<string> orderedBag = new OrderedBag<string>();

            for(int i = 0; i < n; i++)
            {
                orderedBag.Add(line);
                line = Console.ReadLine();
            }

            foreach(string element in orderedBag)
            {
                Console.WriteLine(element);
            }
        }
    }
}
