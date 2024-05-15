using System;

namespace operacii_s_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0.00;
            string kind = " ";

            if (num2 == 0 && (symbol == "/" || symbol == "%")) 
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else
            {

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        if (result % 2 == 1)
                        {
                            kind = "odd";
                        }
                        else
                        {
                            kind = "even";
                        }
                        Console.WriteLine($"{num1} + {num2} = {result} - {kind} "); break;
                    case "-":
                        result = num1 - num2;
                        if (result % 2 == 1)
                        {
                            kind = "odd";
                        }
                        else
                        {
                            kind = "even";
                        }
                        Console.WriteLine($"{num1} - {num2} = {result} - {kind} "); break;
                    case "*":
                        result = num1 * num2;
                        if (result % 2 == 1)
                        {
                            kind = "odd";
                        }
                        else
                        {
                            kind = "even";
                        }
                        Console.WriteLine($"{num1} * {num2} = {result} - {kind} "); break;

                    case "/":
                        result = num1 / num2;
                        double formated = Math.Round(result, 2);

                        Console.WriteLine($"{num1} / {num2} = {formated}"); break;

                    case "%":
                        result = num1 % num2;

                        Console.WriteLine($"{num1} % {num2} = {result}"); break;
                }
            }
        }
    }
}
