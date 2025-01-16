using System;

namespace treta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата цели числа в диапазона от -2,147,483,648 до 2,147,483,647,
            //докато не се получи команда "stop";. Да се намери сумата на всички въведени прости и сумата на всички
            //въведени непрости числа.Тъй като по дефиниция от математиката отрицателните числа не могат да бъдат
            //прости, ако на входа се подаде отрицателно число да се изведе следното съобщение "Number is negative."
            string num = Console.ReadLine();
            int prostiSum = 0;
            int neprostiSum = 0;

            while (num != "stop")
            {

                int currentNum = int.Parse(num);
                bool isProsto = false;

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");

                }
                else
                {
                    for (int i = 2; i <= currentNum; i++)
                    {
                        if (currentNum % i == 0 && currentNum != i)
                        {
                            isProsto = true;
                            break;
                        }
                    }
                    if (isProsto)
                    {
                        neprostiSum += currentNum;

                    }
                    else
                    {
                        prostiSum += currentNum;
                    }
                }
                num = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {prostiSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {neprostiSum}");


        }


    }
}

