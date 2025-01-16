using System;
using System.Linq;
using System.Collections.Generic;
namespace Reversed_vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Vectors(vector, 0);
        }
        static void Vectors(int[] vector, int index)
        {
            if(index > vector.Length - 1)
            {
                vector = vector.Reverse().ToArray();
                Console.WriteLine(string.Join("", vector));
                return;
            }
            for(int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Vectors(vector, index + 1);
            }
        }
    }
}
