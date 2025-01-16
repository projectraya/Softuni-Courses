using System;

namespace deseta
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            char operator1 = char.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculations(first, operator1, second));
        }
        static double Calculations(double first, char operator1, double second)
        {
            double result = 0;
            if(operator1 == '+')
            {
               result = Sum(first, second);
            }
            else if(operator1 == '-')
            {
                result = Minus(first, second);
            }
            else if(operator1 == '*')
            {
                result = Multiply(first, second);
            }
            else if(operator1 == '/')
            {
                result = Divide(first, second);
            }
            return result;
        }
        static double Sum(double first, double second)
        {
            double sum = first + second;
            return sum;
        }
        static double Minus(double first, double second)
        {
            double sum = first - second;
            return sum;
        }
        static double Multiply(double first, double second)
        {
            double sum = first * second;
            return sum;
        }static double Divide(double first, double second)
        {
            double sum = first / second;
            return sum;
        }
    }
}
