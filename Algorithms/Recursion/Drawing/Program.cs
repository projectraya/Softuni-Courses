using static System.Console;
using System;
using System.Linq;
using System.Text;
namespace Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Draw(num));
            Console.WriteLine(DrawHashtag(1, num)); //5
        }

        static string Draw(int n) //5
        {
            if(n == 1)
            {
                return "*";
            }
             for(int i = 0; i < n; i++)
             {
                Console.Write('*');
             }
            Console.WriteLine();

            return Draw(n - 1);
        }

        static string DrawHashtag(int n, int totalRows)
        {
            if(n > totalRows){
                return " ";
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write('#');
            }
            Console.WriteLine();

            return DrawHashtag(n + 1, totalRows);
        }
    }
}
