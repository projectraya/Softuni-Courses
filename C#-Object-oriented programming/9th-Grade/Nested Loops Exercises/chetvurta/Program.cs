using System;

namespace chetvurta
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double final = 0.0;
            int count = 0;

            while(input != "Finish")
            {
                double gradeSum = 0.0;
                for(int i = 0; i < people; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    gradeSum += currentGrade;
                    
                }

                count++;
                double average = gradeSum / people;
                final += gradeSum;

                Console.WriteLine($"{input} - {average:F2}.");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(final / (count*people)):F2}.");
        }
    }
}
