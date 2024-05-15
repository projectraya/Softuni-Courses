using System;

namespace haha_homework_haha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1
            int[,] matrix1 = {
                {1, 1},
                {2, 2}
                };
            int number = 5;
            bool result = Contains(matrix1, number);
            Console.WriteLine($"matrix1 contains the number { number}: " + result);
            // Test 2
            int[,] matrix2 = {
                {1, 1, 5},
                {2, 2, 2},
                {3, 3, 3}
                };
            number = 5;
            result = Contains(matrix2, number);
            Console.WriteLine($"matrix2 contains the number { number}: " + result);
            // Test 3
            int[,] matrix3 = {
            };
            number = 5;
            result = Contains(matrix3, number);
            Console.WriteLine($"matrix3 contains the number { number}: " + result);
        }
        static bool Contains(int[,] matrix, int number)
        {
            // TODO: Implement this method
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(0); c++)
                {
                    if(matrix[r, c] == number) { 
                    }
                }
                

            }
                return false;
        }
    }
}
