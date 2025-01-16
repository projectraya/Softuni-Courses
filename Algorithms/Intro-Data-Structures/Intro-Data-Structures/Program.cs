using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Intro_Data_Structures
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            string word4 = Console.ReadLine();

            list.AddFirst(word1);
            list.AddLast(word2);
            list.AddAfter(list.First, word3);
            list.AddBefore(list.Last, word4);

            Console.WriteLine(string.Join(", ", list));


        }
    }
}
