namespace Matrix_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(rows, cols);
            FindPath(matrix);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = numbers[col];
                }
            }

            return matrix;
        }

        static void FindPath(int[,] matrix)
        {
            int position = matrix[0, 0];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            bool thereIsPath = false;

            int row = 0; int col = 0;

            while (position != 9)
            {
                if (row + 1 < rows && matrix[row + 1, col] == position + 1) //down
                {
                    position = matrix[row + 1, col];
                    row++;

                }
                else if (col + 1 < cols && matrix[row, col + 1] == position + 1) //right
                {
                    position = matrix[row, col + 1];
                    col++;

                }
                else if (col - 1 >= 0 && matrix[row, col - 1] == position + 1) //left
                {
                    position = matrix[row, col - 1];
                    col--;

                }
                else if (row - 1 >= 0 && matrix[row - 1, col] == position + 1) //up
                {
                    position = matrix[row - 1, col];
                    row--;
                }
                


            }
            if (position == 9)
            {
                thereIsPath = true;
            }

            if (thereIsPath)
            {
                Console.WriteLine("Path 1..9 is found!");
            }
            else
            {
                Console.WriteLine($"Path 1..9 is not found!");
            }
        }
    }
}
