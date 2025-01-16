using System;

namespace vtora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for(int i = num1; i < num2; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                string currentNumber = (i.ToString());

                for(int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());

                    if(j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                    
                }
                if(evenSum == oddSum)
                {
                    Console.Write($"{currentNumber} ");
                }
            }    
            
        }
    }
}
