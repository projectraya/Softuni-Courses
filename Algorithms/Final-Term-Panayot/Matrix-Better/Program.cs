namespace Matrix_Better
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = numbers[col];
                }
            }

            FindPath(matrix);
        }

        static void FindPath(int[,] matrix)
        {
            int number = matrix[0, 0];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            bool thereIsPath = false;

            int row = 0; int col = 0;
            if(rows <= 1)
            {
                Console.WriteLine("No path!");
                return;
            }

            while (row <= rows - 1)
            {

                if (row == rows - 1) //if on the last row
                {
                    if (matrix[row, col] == number)
                    {
                        thereIsPath = true;
                        row++;

                    }
                    else if (col + 1 < cols && matrix[row, col + 1] == number)
                    {
                        thereIsPath = true;
                        row++;

                    }
                    else if (col - 1 >= 0 && matrix[row, col - 1] == number)
                    {
                        thereIsPath = true;
                        row++;
                    }
                    else
                    {
                        thereIsPath = false;
                    }
                }
                else if (row + 1 < rows && matrix[row + 1, col] == number + 1) //down
                {
                    number = matrix[row + 1, col];
                    row++;
                    

                }
                else if (row + 1 < rows && col + 1 < cols && matrix[row + 1, col + 1] == number + 1) //down right
                {
                    number = matrix[row + 1, col + 1];
                    row++;
                    col++;

                }
                else if (row + 1 < rows && col - 1 >= 0 && matrix[row + 1, col - 1] == number + 1) //down left
                {
                    number = matrix[row + 1, col - 1];
                    row++;
                    col--;

                }
                else
                {
                    Console.WriteLine("No path!");
                    return;
                }

            }
            

            if (thereIsPath)
            {
                Console.WriteLine("There is a path!");
            }
            else
            {
                Console.WriteLine($"No path!");
            }
        }


    }
}
