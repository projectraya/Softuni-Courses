using System;
using System.Linq;
using System.Collections.Generic;


namespace primary_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[n, n];
            int sum = 0;

            for(int rows = 0; rows < n; rows++)
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

            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);

        }
    }
}
