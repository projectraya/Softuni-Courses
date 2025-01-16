using System;
using System.Linq;
using System.Collections.Generic;

namespace symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            
            for (int rows = 0; rows < n; rows++)
            {
                string word = Console.ReadLine();

                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = word[cols];
                    
                }
                
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isThere = true;
            for(int r = 0; r < n; r++)
            {
                for(int c = 0; c < n; c++)
                {
                    if(symbol == matrix[r, c])
                    {
                        Console.WriteLine($"({r}, {c})");
                        break;
                    }
                    else
                    {
                        isThere = false;
                    }
                }
            }
            if(isThere == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
