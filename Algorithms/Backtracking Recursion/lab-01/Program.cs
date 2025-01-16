namespace lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(6)); //what is the sum of the numbers up to 5? - 1 2 3 4 5
        }

        static int Sum(int n)
        {
            //what is the most basic version of this problem?
            //n = 0 => 0
            //n = 1 => 1
            //n = 2 => 1 + 2 = 3
            //n = 3 => 1 + 2 + 3 = 6
            //n = 4 => 1 + 2 + 3 + 4 = 10
            //n = 5 => 1 + 2 + 3 + 4 + 5 = 15 || 10 + 5 || sum(4) + 5 = 15
            
            if(n == 0)
            {
                return 0;
            }

            int currentSum = n + Sum(n - 1);
            Console.WriteLine($"{currentSum - n} + {n} = {currentSum}");

            return currentSum;
            
            
        }
    }
}
