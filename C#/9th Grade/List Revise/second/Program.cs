using System;
using System.Collections.Generic;
using System.Linq;

namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //second task

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).Where(x => x > 0).ToList();

            nums.Reverse();

            if (nums.Count > 0)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
