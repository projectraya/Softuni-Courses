using System;
using System.Collections.Generic;
using System.Linq;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            Stack<string> stack = new Stack<string>();
            Stack<int> stackOfSums = new Stack<int>();
            int sum = 0;

            for(int i = 0; i < input.Count; i++)
            {
                stack.Push(input[i]);
                
            }
            stack.Reverse();
            List<string> currentCalculation = new List<string>(3);
            for (int j = 0; j < stack.Count; j++)
            {
                
                if (currentCalculation.Count != 3)
                {
                    currentCalculation.Add(input[j]);
                }
                else
                {

                    if (currentCalculation[1] == "+")
                    {
                        int currentSum = int.Parse(currentCalculation[0]) + int.Parse(currentCalculation[2]);
                        sum += currentSum;
                        currentCalculation.Clear();
                    }
                    else if (currentCalculation[1] == "-")
                    {
                        int currentSum = int.Parse(currentCalculation[0]) - int.Parse(currentCalculation[2]);
                        sum += currentSum;
                        currentCalculation.Clear();
                    }
                    stackOfSums.Push(sum);
                }

            }
            Console.WriteLine(stackOfSums.Sum());
            
        }
    }
}
