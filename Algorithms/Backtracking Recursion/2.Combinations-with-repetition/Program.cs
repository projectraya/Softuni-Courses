namespace _2.Combinations_with_repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[k];
            Combinations(n, 0, numbers);
            
        }

        static void Combinations(int n, int index, int[] numbers)
        {
            if (index < n) //if the last number gets bigger than n return
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = index;
                Combinations(n, index + 1, numbers);
            }

        }
    }
}
