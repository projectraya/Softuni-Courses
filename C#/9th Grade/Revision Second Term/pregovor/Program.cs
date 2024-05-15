using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace pregovor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ================ 1. Multidimentional arrays ================     (rows with values)
            // Деклариране
            int[,] matrix4x4 = new int[4, 4];

            //Четене от конзола
            int rowSize = int.Parse(Console.ReadLine());
            int valueSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rowSize, valueSize];
            for(int row = 0; row < rowSize; row++)
            {
                string[] numbers = Console.ReadLine().Split(", ").ToArray(); //read the nums

                for(int value = 0; value < valueSize; value++)
                {
                    matrix[row, value] = numbers[value]; //fill the matrix

                }
            }

            //Печатане в конзолата

            for(int i = 0; i < rowSize; i++)
            {
                for(int j = 0; j < valueSize; j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }

            
            // Въвеждане в kода / hardcode
            int[,] hardCodedMatrix = {
                    {1, 2, 3},
                    {4, 5, 6},
                    };

            // Печатane в конзолата
            for (int i = 0; i < hardCodedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < hardCodedMatrix.GetLength(1); j++)
                {
                    Console.Write(hardCodedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Допълнителни функции и действия
            hardCodedMatrix.GetLength(0); // Count of rows
            hardCodedMatrix.GetLength(1); // Count of columns

            //TODO: add other useful snippets here
            int rowLen = int.Parse(Console.ReadLine());
            int valLen = int.Parse(Console.ReadLine());

            string[,] matrix1 = new string[rowLen, valLen]; //matrixes are rows with values


            //jagged array

            
            int[][] jagged = new int[2][];
            jagged[0] = new int[3];

            jagged[1] = new int[2];

            for (int row = 0; row < jagged.Length; row++)

            {
                string[] inputNumbers = Console.ReadLine().Split(' ');

                jagged[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)

                {

                    jagged[row][col] = int.Parse(inputNumbers[col]);

                }

            }

#





            // ================ 2. Dictionaries ================ 
            // TODO: Write code snippets here

            // Деклариране и четене от конзола
            Dictionary<string, double> fruits = new Dictionary<string, double>();
            fruits["banana"] = 2.20;
            fruits["apple"] = 1.40;
            fruits["kiwi"] = 3.20;

            Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();
            grades["Peter"] = new List<int>();
            grades["Peter"].Add(5);
            grades["Peter"].Add(7);
            Console.WriteLine(string.Join(" ", grades["Peter"]));

            
            // Допълнителни функции и действия
            fruits.Add("orange", 4.20);
            fruits.Remove("apple");

            if(fruits.ContainsKey("tomato") || fruits.ContainsValue(4.20))
            {
                Console.WriteLine("Wow");
            }
            
            // Въвеждане в kода / hardcode
            // Печатane в конзолата
            foreach(KeyValuePair<string, double> fruitAndPrice in fruits)
            {
                Console.WriteLine($"The fruit {fruitAndPrice.Key} costs {fruitAndPrice.Value} leva.");
            }
            

            // ================ 3. Functional programming / Linq ================ 
            // No need to read or print in console, however:

            // x => x     Anonymous function doing nothing. Same as:

            int doNothing(int x)
            {
                return x;
            }

            // or
            Func<int, int> DoNothing = (x => x);


            // x => x == 5  Anonymous predicate checking if x is 5. Same as:
            bool check(int x)
            {
                return x == 5;
            }

            // or
            Predicate<int> Check = (x => x == 5);


            // x => x * 10  Anonymous function to multiply x by 10. Same as:
            int tenfold(int x)
            {
                return x * 10;
            }


            // () => 5      Anonymous function always returning the number 5. Same as:
            int NoParam()
            {
                return 5;
            }

            // or
            Func<int> NoParameter = (() => 5);

            // Void functions are called Actions.
            Action<double> PrettyPrint = (num => Console.WriteLine($"{num:f2}"));

            // is the same as
            void prettyPrint(double num)
            {
                Console.WriteLine($"{num:f2}");
            }



            // ================ 4. Classes and objects ================ 
            // TODO: Write code snippets here
            // Деклариране и четене от конзола
            // Въвеждане в kода / hardcode
            // Печатane в конзолата
            // Допълнителни функции и действия

            // ================ 5. Strings, text processing and RegEx ================
            // TODO: Write code snippets here
            // String builder
            // Using strings as arrays of chars
            // Using RegEx in C# code - Match, MatchCollection...
            // RegEx rules and examples
        }
    }
}
