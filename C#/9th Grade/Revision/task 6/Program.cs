using System;

namespace forzadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                if(i%21!=0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
