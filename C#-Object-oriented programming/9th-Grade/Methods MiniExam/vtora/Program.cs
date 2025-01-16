using System;

namespace vtora
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateResult(firstNum, secondNum, thirdNum));
        }
        static int CalculateResult(int firstNum, int secondNum, int thirdNum)
        {
            int result = GetSum(firstNum, secondNum) - thirdNum;

            return result;
        }
        static int GetSum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
