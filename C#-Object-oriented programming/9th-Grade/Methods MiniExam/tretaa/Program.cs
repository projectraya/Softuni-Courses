using System;

namespace tretaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix(number);
        }
        static void PrintMatrix(int number)
        {
            for(int i = 0; i < number; i++) //a loop for the amount of rows
            {
                for(int j = 0; j < number; j++) //a loop for the numbers on the row
                {
                    Console.Write(number + " ");
                    
                }
                Console.WriteLine();
            }
        }

    }
}
