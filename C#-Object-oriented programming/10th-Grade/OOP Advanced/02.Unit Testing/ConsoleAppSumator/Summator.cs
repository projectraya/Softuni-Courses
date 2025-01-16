namespace ConsoleAppSumator
{
    public class Summator
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new int[] { 10, 20, 30 }));
        }

        public static int Sum(int[] arr)
        {
            int sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int Multiplier(int[] input)
        {
            int result = 0;
            for(int i = 0; i < input.Length; i++)
            {
                result *= input[i];
            }
            return result;
        }
    }
}
