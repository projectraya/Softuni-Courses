using System;

namespace zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string firstME = Console.ReadLine();
            string secondME = Console.ReadLine();
            int result = 0;

            if (firstME == "mm")
            {
                if (secondME == "cm")
                {
                    result = number / 10;
                }
                else if (secondME == "m")
                {
                    result = number / 1000;
                }
            }
            else if (firstME == "cm")
            {
                if (secondME == "mm")
                {
                    result = number * 10;
                }
                else if (secondME == "m")
                {
                    result = number / 100;
                }
            }
            else if (firstME == "m")
            {
                if (secondME == "mm")
                {
                    result = number * 1000;
                }
                else if (secondME == "cm")
                {
                    result = number * 100;
                }
            }

            Console.WriteLine("{0:F3}", result);
        }
    }
}
