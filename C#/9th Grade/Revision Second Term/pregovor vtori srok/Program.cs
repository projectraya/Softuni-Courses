﻿using System;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix1 = {
                { 'a', 'b', 'c', 'd'},
                { 'e', 'f', 'g', 'h'},
                { 'i', 'j', 'k', 'l'},
                { 'm', 'n', 'o', 'p'},
            };

            char[,] matrix2 = {
                { 'a', 'b', 'c', 'd'},
                { 'k', 'i', 'w', 'i'},
                { 'i', 'j', 'k', 'l'},
                { 'm', 'n', 'o', 'p'},
            };

            char[,] matrix3 = {
                { 'a', 'k', 'c', 'd'},
                { 'e', 'i', 'g', 'h'},
                { 'i', 'w', 'k', 'l'},
                { 'm', 'i', 'o', 'p'},
            };

            char[,] matrix4 = {
                { 'a', 'k', 'i', 'w', 'i'},
                { 'e', 'f', 'k', 'h', 'd'},
                { 'i', 'j', 'i', 'l', 'd'},
                { 'm', 'n', 'w', 'p', 'd'},
                { 'm', 'n', 'i', 'p', 'd'},
            };

            string keyword = "kiwi";

            Console.WriteLine(WordCountCheck(matrix1, keyword));
            Console.WriteLine(WordCountCheck(matrix2, keyword));
            Console.WriteLine(WordCountCheck(matrix3, keyword));
            Console.WriteLine(WordCountCheck(matrix4, keyword));
        }

        

        static int WordCountCheck(char[,] matrix, string keyword)
        {
            int count = 0;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (keyword.Length > rows && keyword.Length > cols)
            {
                return 0;
            }

            // Lazy

            // Search for horizontal
            for (int row = 0; row < rows; row++)
            {
                for (int startIdx = 0; startIdx <= cols - keyword.Length; startIdx++)
                {
                    bool found = true;
                    for (int i = startIdx; i < startIdx + keyword.Length - 1; i++)
                    {
                        if (matrix[row, i] != keyword[i])
                        {
                            found = false;
                        }
                       
                    }
                    if (found)
                    {
                        count++;
                    }
                }
            }

            // Search for vertical
            for (int col = 0; col < cols; col++)
            {
                for (int startIdx = 0; startIdx <= rows - keyword.Length; startIdx++)
                {
                    bool found = true;
                    for (int i = startIdx; i < startIdx + keyword.Length - 1; i++)
                    {
                        if (matrix[i, col] != keyword[i])
                        {
                            found = false;
                        }
                        
                    }
                    if (found)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
