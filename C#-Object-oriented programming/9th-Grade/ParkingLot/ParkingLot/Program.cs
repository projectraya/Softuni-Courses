using System;
using System.Linq;
using System.Collections.Generic;

namespace sets_and_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> strings = new HashSet<string>();
            string[] input = Console.ReadLine().Split(", ").ToArray();

            while (input[0] != "END")
            {
                
                if (input[0] == "IN")
                {
                    strings.Add(input[1]);

                }else if (input[0] == "OUT")
                {
                    strings.Remove(input[1]);
                }
                input = Console.ReadLine().Split(", ").ToArray();
            }

            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
            if(strings.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
