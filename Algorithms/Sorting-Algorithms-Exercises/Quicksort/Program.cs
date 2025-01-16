namespace Quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] array = new int[] { 1, 5, 42, 6, 9, 42 };
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Quick.Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }

    public class Quick
    {
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
        private static void Sort(int[] array, int leftIndx, int rightIndx)
        {
            if(leftIndx >= rightIndx)
            {
                return;
            }
            int pivot = Partition(array, leftIndx, rightIndx);

            Sort(array, leftIndx, pivot - 1);
            Sort(array, pivot + 1, rightIndx);
        }
        private static int Partition(int[] array, int leftIndx, int rightIndx)
        {
            if(leftIndx >= rightIndx)
            {
                return leftIndx;
            }

            int i = leftIndx;
            int j = rightIndx + 1;

            while (true)
            {
                while (Less(array[++i], array[leftIndx]))
                {
                    if (i == rightIndx) break;
                }

                while (Less(array[leftIndx], array[--j]))
                {
                    if (j == leftIndx) break;
                }

                if (i >= j) break;

                Swap(array, i, j);
               

            }

            Swap(array, leftIndx, j);
            

            return j;
        }

        public static void Swap(int[] array, int a, int b)
        {
            int numA = array[a];
            array[a] = array[b];
            array[b] = numA;
        }

        public static bool Less(int a, int b)
        {
            if (a < b)
            {
                return true;
            }

            return false;
        }
    }
}
