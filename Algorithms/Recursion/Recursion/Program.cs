    using static System.Console;
    using System;
    using System.Linq;
    namespace Recursion
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int sum = Sum(numbers, 0);
                Console.WriteLine(sum);
           
            }
            static int Sum(int[] array, int index)

            {

                if (index == array.Length - 1)

                {

                    return array[index];

                }

                return array[index] + Sum(array, index + 1);

            }
        }
    }
