using System;
using System.Linq;
using System.Collections.Generic;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); //parametri na matrix
            
            int r = size[0];
            int c = size[1];
            int[,] matrix = new int[r, c]; // creating the matrix with the parameters


            for(int rows = 0; rows < matrix.GetLength(0); rows++) //loop for redove
            {
                int[] nums = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++) //loop for chisla na redovete
                {
                    matrix[rows, cols] = nums[cols];  // na matrix[0, 0] slaga 0levoto ot nums
                    
                }
                
            }

            
            for(int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row< matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                    
                Console.WriteLine(sum);
            }
        }
    }
}
