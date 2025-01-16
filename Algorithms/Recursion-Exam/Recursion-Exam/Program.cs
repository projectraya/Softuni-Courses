using System;
using System.Linq;
using System.Collections.Generic;
namespace Recursion_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            KFigure(n, 0);
        }
        static void KFigure(int input, int count)
        {
            
            if(input <= 0)
            {
                return;
            }
            if(count > 0)
            {
                Console.Write(new string (' ', count));
            }
            
            Console.WriteLine(new string('#', input));
            KFigure(input - 1, count + 1);

            if (count > 0)
            {
                Console.Write(new string(' ', count));
            }

            Console.WriteLine(new string('*', input));
           
        }
        
    }
}
