namespace Algorithms_Final_Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            for(int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            BubbleSort(array);
            foreach(int num in array)
            {
                Console.WriteLine(num);
            }
        }
        static void BubbleSort(int[] array)
        {
            for(int f = 0; f < array.Length; f++)
            {
                for (int i = 1; i < array.Length - 1; i++)
                {
                    int leftIndex = i - 1;
                    int rightIndex = i; //2 1 3 => 3 2 1

                    if (array[leftIndex] < array[rightIndex])
                    {
                        Swap(array, leftIndex, rightIndex);
                    }
                }
            }
            
        }
        static void Swap(int[] array, int a, int b)
        {
            int stat = array[a];
            array[a] = array[b];
            array[b] = stat;
        }
    }
}
