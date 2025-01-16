namespace Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReversedArray(numbers, numbers.Length - 1);
        }
        static int ReversedArray(int[] array, int index)
        {
            
            if(index == 0)
            {
                Console.Write(array[index] + " ");
                return array[index];
                
            }

            Console.Write(array[index] + " ");
            return ReversedArray(array, index - 1);


        }
    }
}
