using System;
using System.Linq;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];
            //Reading

            for(int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[numbers.Length];
                for(int i = 0; i < numbers.Length; i++)
                {
                    jaggedArray[row][i] = numbers[i];
                }
            }
            //Solution

            string[] command = Console.ReadLine().Split().ToArray();
            while(command[0] != "END")
            {
                int r = int.Parse(command[1]);
                int c = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (r > n || c > jaggedArray[r].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command[0] == "Add")
                    {
                        jaggedArray[r][c] += value;
                        break;
                    }
                    else if(command[0] == "Subtract")
                    {
                        jaggedArray[r][c] -= value;
                        break;
                    }
                }
                
                
                command = Console.ReadLine().Split().ToArray();
            }
            //Printing

            for(int rows = 0; rows < n; rows++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[rows]));
            }
        }
    }
}
