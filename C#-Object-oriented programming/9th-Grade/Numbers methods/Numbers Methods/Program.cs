using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersFirst = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbersSecond = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> finalList = new List<int>();
            //Solution
           
            if(numbersFirst.Count < numbersSecond.Count)
            {
               
                for(int i = 0; i < numbersFirst.Count; i++)
                {
                    finalList.Add(numbersFirst[i]);

                    finalList.Add(numbersSecond[i]);
                }
                for(int j = numbersFirst.Count; j < numbersSecond.Count; j++)
                {
                    finalList.Add(numbersSecond[j]);
                }
            }
            else
            {
                
                for (int i = 0; i < numbersSecond.Count; i++)
                {
                    finalList.Add(numbersFirst[i]);

                    finalList.Add(numbersSecond[i]);
                }
                
                for (int j = numbersSecond.Count; j < numbersFirst.Count; j++)
                {
                    finalList.Add(numbersFirst[j]);
                }
            }
            


            //Output
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
