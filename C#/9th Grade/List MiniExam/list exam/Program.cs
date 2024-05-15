using System;
using System.Linq;
using System.Collections.Generic;

namespace list_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> groups = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            

            groups.Reverse();

            for(int j = 0; j < groups.Count; j++)
            {
                string word = groups[j];
                groups[j] = word.Trim();
            }
            
            Console.WriteLine(string.Join(" ", groups));
        }
    }
}
