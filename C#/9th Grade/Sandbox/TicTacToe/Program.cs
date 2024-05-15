using System;
using System.Linq;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ")
                .Skip(1)
                .OrderBy(w => w)
                
                .OrderBy(w => w.Length)
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length < 5)
                {
                    Console.WriteLine(words[i] + "s");
                }
            }
        }
    }
}
