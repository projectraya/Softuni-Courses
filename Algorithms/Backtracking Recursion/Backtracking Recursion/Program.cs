using System;
using System.Linq;
namespace Backtracking_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            GeneratingVectors(nums, 0);
        }
        static void GeneratingVectors(int[] nums, int a)
        {
            
            if(a > nums.Length - 1)
            {
                Console.WriteLine(string.Join("", nums));
                return;
            }

            for(int i = 0; i <= 1; i++)
            {
                nums[a] = i;
                GeneratingVectors(nums, a + 1);
            }
        }

    }
}
