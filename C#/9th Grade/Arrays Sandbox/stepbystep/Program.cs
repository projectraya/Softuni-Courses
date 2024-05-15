using System;
using System.Linq;

namespace stepbystep
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //int[] numbers1 = {4, 3}; vtori nachin za masiv
            //int[] numbers2 = new int[5] //5 e kolko inta ima v int kvadratcheto[]

            string input = Console.ReadLine();
            string[] names = input.Split();
            int n = names.Length;
            int[] numbers = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(names[i]);
            }
            //nai dulgiq nachin da poluchish napisanite stringove v chisla

            //using System.Linq
            int[] numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


        }
    }
}
