using System;

namespace for_loop_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for(int i = 0; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if(num > max)
                {
                    max = num;
                }
                

                
            }
        }
    }
}
