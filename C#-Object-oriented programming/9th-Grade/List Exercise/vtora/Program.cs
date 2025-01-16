using System;
using System.Linq;
using System.Collections.Generic;

namespace vtora
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> input = Console.ReadLine().Split().ToList();
            while (input[0] != "end")
            {

                if(input[0] == "Delete")
                {
                    int current = int.Parse(input[1]);
                    numbers.Remove(current);
                }
                if(input[0] == "Insert")
                {
                    int position = int.Parse(input[2]);
                    int index = int.Parse(input[1]);
                    numbers.Insert(int.Parse(input[1]), position);
                    
                    
                }
                input = Console.ReadLine().Split().ToList(); 
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
