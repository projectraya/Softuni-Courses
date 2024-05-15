using System;
using System.Linq;
using System.Collections.Generic;

namespace again
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groups = Console.ReadLine().Split("|").ToList();


            groups.Reverse();

            for (int j = groups.Count - 1; j >= 0; j--)
            {

                groups[j].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", groups));
        }
    }
}
