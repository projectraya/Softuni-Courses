using static System.Console;
using System;
using System.Linq;
namespace Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReversedArray(numbers, 0);
        }
        static void ReversedArray(int[] array, int index)
        {

            if (index == array.Length)
            {
                return;

            }


            ReversedArray(array, index + 1);
            Console.Write(array[index] + " "); //when exiting all the future functions, it writes on the console the number


        }
    }
}
