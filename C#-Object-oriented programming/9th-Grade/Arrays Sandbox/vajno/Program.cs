using System;

namespace vajno
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] names = input.Split();
           Console.WriteLine(names[1]);
        }
    }
}
