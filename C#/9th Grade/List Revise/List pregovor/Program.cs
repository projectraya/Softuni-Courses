using System;
using System.Linq;
using System.Collections.Generic;

namespace List_pregovor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //third task

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();
            while(command[0] != "end")
            {
                
                switch (command[0])
                {
                    case "Contains":
                        if (nums.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        foreach(int num in nums)
                        {
                            if(num % 2 == 0)
                            {
                                Console.Write(num + " ");
                            }
                        }
                        break;

                    case "PrintOdd":
                        foreach (int num in nums)
                        {
                            if (num % 2 == 1)
                            {
                                Console.Write(num + " ");
                            }
                        }
                        break;

                    case "GetSum":
                        int sum = 0;
                        foreach (int num in nums)
                        {
                            sum += num;
                        }
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        string condition = command[1]; // <=
                        int compareTo = int.Parse(command[2]);
                        foreach (int num in nums)
                        {
                            if(Filter(condition, compareTo, num))
                            {
                                Console.Write(num + " ");
                            }
                        }

                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
        static bool Filter(string condition, int compareTo, int current)
        {
            bool isTrue = false;
            if (condition == "<")
            {
                if(current < compareTo)
                {
                    isTrue = true;
                    return isTrue;
                }
            }
            else if(condition == "<=")
            {
                if (current <= compareTo)
                {
                    isTrue = true;
                    return isTrue;
                }
            }
            else if (condition == ">")
            {
                if (current > compareTo)
                {
                    isTrue = true;
                    return isTrue;
                }
            }
            else if (condition == ">=")
            {
                if (current >= compareTo)
                {
                    isTrue = true;
                    return isTrue;
                }
                
            }
            else
            {
                return false;
            }
        }
    }
}
