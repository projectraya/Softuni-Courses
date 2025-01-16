using System;
using System.Linq;
namespace Backtracking_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] combination = new int[k];
            
            

            Combinations(combination, 0, n, 1);
        }
        static void Combinations(int[] nums, int index, int n, int startNum)
        {
            if(index > nums.Length - 1)
            {
                Console.WriteLine(string.Join(" ", nums));
                return;
            }

            for(int i = startNum; i <= n; i++)
            {
                nums[index] = i; // [2] = 1
                
                Combinations(nums, index + 1, n, i);
            }
        }

    }
}
