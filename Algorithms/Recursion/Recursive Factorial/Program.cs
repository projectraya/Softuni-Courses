using static System.Console;
using System;
using System.Linq;
namespace Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }

        static long Factorial(int n) //5
        {
            //bottom
            if(n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
            //return the multiple of (n - 1)
        }
    }
}
