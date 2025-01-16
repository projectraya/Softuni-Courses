namespace Sorting_Algorithms_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //InsertionSort(array);
            BubbleSort(array);
            Console.WriteLine(string.Join(" ", array));
        }

        public static void InsertionSort(int[] array)
        {

            for(int startIndex = 1; startIndex < array.Length; startIndex++)
            {
                int firstNum = array[startIndex - 1];
                int secondNum = array[startIndex];

                int currentIndex = startIndex;

                if(secondNum < firstNum)
                {
                    for(int i = startIndex; i >= 0; i--)
                    {
                        if (array[i] > secondNum)
                        {
                            Swap(array, currentIndex, currentIndex - 1);
                            
                            //int numA = array[currentIndex];
                            //array[currentIndex] = array[currentIndex - 1];
                            //array[currentIndex - 1] = numA;

                            currentIndex--;
                        }
                    }
                }
            }
        }

        public static void BubbleSort(int[] array)
        {
            for(int all = 0; all < array.Length - 1; all++)
            {
                for (int i = 1; i <= array.Length - 1; i++) // 5 4 3 2 1
                                                            //4 5 3 2 1    //4 3 5 2 1  //4 3 2 5 1   //4 3 2 1 5
                {
                    int leftNum = array[i - 1];
                    int rightNum = array[i];

                    int leftNumIndex = i - 1;
                    int rightNumIndex = i;

                    if (leftNum > rightNum)
                    {
                        Swap(array, leftNumIndex, rightNumIndex);

                    }
                }
            }
            
        }
       

        public static void Swap(int[] array, int a, int b)
        {
            int numA = array[a];    
            array[a] = array[b];
            array[b] = numA;
        }
    }
}
