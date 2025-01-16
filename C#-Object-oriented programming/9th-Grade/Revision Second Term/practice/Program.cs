using System;
using System.Linq;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rowLen = dimensions[0];
            int valLen = dimensions[1];

            string[,] matrix = new string[rowLen, valLen];
            for (int row = 0; row < dimensions[0]; row++)
            {
                string[] numbers = Console.ReadLine()
                .Split()
                
                .ToArray();

                for (int value = 0; value < dimensions[1]; value++)
                {
                    matrix[row, value] = numbers[value];
                }
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                if (command.Length < 5 || command.Length > 5)
                {
                    Console.WriteLine("The input is invalid!");
                    
                }
                else
                {
                    int x1 = int.Parse(command[1]);
                    int y1 = int.Parse(command[2]);
                    int x2 = int.Parse(command[3]);
                    int y2 = int.Parse(command[4]);

                    if (x1 > rowLen || x1 < 0 || y1 > valLen || y1 < 0
                        || x2 > rowLen || x2 < 0 || y2 > valLen || y2 < 0)
                    {
                        Console.WriteLine("The input is invalid!");
                    }
                    else
                    {
                        string saveNum = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = saveNum;

                        //print the matrix
                        for(int i = 0; i < rowLen; i++)
                        {
                            for(int j = 0; j < valLen; j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
