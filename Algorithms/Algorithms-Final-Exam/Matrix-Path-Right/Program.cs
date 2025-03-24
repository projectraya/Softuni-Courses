using System;

namespace Matrix_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());  
            int w = int.Parse(Console.ReadLine());  

            int[,] matrix = new int[h, w];

            
            for (int i = 0; i < h; i++)
            {
                int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < w; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            bool pathFound = FindPath(matrix, h, w);

            if (pathFound)
            {
                Console.WriteLine("Path 1..9 is found!");
            }
            else
            {
                Console.WriteLine("Path 1..9 is not found!");
            }
        }

        static bool FindPath(int[,] matrix, int h, int w)
        {
            bool[,] visited = new bool[h, w];

            
            int[] dRow = { -1, 1, 0, 0 };
            int[] dCol = { 0, 0, -1, 1 };

            
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        
                        if (DFS(matrix, h, w, i, j, 1, visited, dRow, dCol))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        static bool DFS(int[,] matrix, int h, int w, int row, int col, int num, bool[,] visited, int[] dRow, int[] dCol)
        {
            
            if (num == 9)
                return true;

            
            visited[row, col] = true;

            
            for (int i = 0; i < 4; i++)
            {
                int newRow = row + dRow[i];
                int newCol = col + dCol[i];

                
                if (newRow >= 0 && newRow < h && newCol >= 0 && newCol < w &&
                    !visited[newRow, newCol] && matrix[newRow, newCol] == num + 1)
                {
                    
                    if (DFS(matrix, h, w, newRow, newCol, num + 1, visited, dRow, dCol))
                    {
                        return true;
                    }
                }
            }

            
            visited[row, col] = false;
            return false;
        }
    }
}
