﻿using System;

namespace peta
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    for(int k = 'a'; k < 'a' + l; k++)
                    {
                        for(int o = 'a'; o < 'a' + l; o++)
                        {
                            for(int p = 1; p <= n; p++)
                            {
                                if(p > i && p > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)o}{p} ");
                                }
                                
                            }
                        }
                    }
                }
            }

        }
    }
}
