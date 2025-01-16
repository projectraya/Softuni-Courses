using System;

class Program
{
    public static void MergeSort(int[] array)
    {
        if (array.Length <= 1)
            return;

        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        Array.Copy(array, 0, left, 0, middle);
        Array.Copy(array, middle, right, 0, array.Length - middle);

        
        MergeSort(left);
        MergeSort(right);

        
        Merge(array, left, right);
    }

    private static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k++] = left[i++];
            }
            else
            {
                array[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            array[k++] = left[i++];
        }

        
        while (j < right.Length)
        {
            array[k++] = right[j++];
        }
    }

    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        MergeSort(array);

        Console.WriteLine(string.Join(" ", array));
    }
}
