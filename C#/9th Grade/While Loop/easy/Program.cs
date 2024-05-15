using System;

namespace easy
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int max = int.MaxValue;

            while (num != "Stop")
            {
                int n = int.Parse(num);
                if(n < max)
                {
                    max = n;
                }
                
                num = Console.ReadLine();
            }
                Console.WriteLine(max);
        }
    }
}
