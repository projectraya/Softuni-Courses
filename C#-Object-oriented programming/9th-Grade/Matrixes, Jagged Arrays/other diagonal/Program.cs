using System;
using System.Linq;
using System.Collections.Generic;

namespace other_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int sum = 0;

            for (int rows = 0; rows < n; rows++)
            {
                int[] nums = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = nums[cols];
                }

            }

            for (int c = 0; c < n; c++)
            {
                int num = n - c;
                sum += matrix[c, num - 1];
                
            
            }
            
           
            Console.WriteLine(sum);

        }
    }
}
