using System;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: 
                case 2: 
                case 3: 
                case 4: 
                case 5: Console.WriteLine("Work day"); break;
                case 6: 
                case 7: Console.WriteLine("Weekend"); break;
                default: Console.WriteLine("Error"); break;
            }
        }
    }
}
