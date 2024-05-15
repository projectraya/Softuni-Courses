using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (;;)
            {
                i = i + 1; //poigrai si s tezi, ne e zaduljitelno da ima nishto v uslovieto na fora
                Console.WriteLine(i);
                if(i >= 12)
                {
                    break;
                }
            }
        }
    }
}
