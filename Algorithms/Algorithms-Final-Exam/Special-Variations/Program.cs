namespace Special_Variations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[] arr = new char[number];
            RecursivePrint(arr, number, 0);
        }


        public static void RecursivePrint(char[] arr, int number, int index)
        {

            if (index == number)
            {
                int validCount = 0;
                for(int j = 1; j <= arr.Length - 1; j++)
                {
                    if (arr[j - 1] <= arr[j])
                    {
                        validCount++;
                    }
                }
                if(validCount == arr.Length - 1)
                {
                    Console.WriteLine(string.Join("", arr));
                }
                return;
            }


            for (int i = 0; i < number; i++)
            {
                arr[index] = (char)('a' + i);
                RecursivePrint(arr, number, index + 1);
            }
        }
    }
}
