
using System;

namespace merni_edinici
    {
        class Program
        {
            static void Main(string[] args)
            {
                double number = double.Parse(Console.ReadLine());
                string firstM = Console.ReadLine();
                string secondM = Console.ReadLine();
                double finalNumber = 0.0 ;

                if (firstM == "mm")
                {
                    if (secondM == "cm")
                    {
                        finalNumber = number / 10;
                    }
                    else if (secondM == "m")
                    {
                        finalNumber = number / 1000;

                    };
                    Console.WriteLine("{0:F3}", finalNumber);
                }
                if (firstM == "cm")
                {
                    if (secondM == "mm")
                    {
                        finalNumber = number * 10;
                    }
                    else if (secondM == "m")
                    {
                        finalNumber = number / 100;
                    };

                    Console.WriteLine("{0:F3}", finalNumber);
                }
                if (firstM == "m")
                {
                    if (secondM == "mm")
                    {
                        finalNumber = number * 1000;
                    }
                    else if (secondM == "cm")
                    {
                        finalNumber = number * 100;
                    };

                    Console.WriteLine("{0:F3}", finalNumber);
                }

            }
        }
    }

