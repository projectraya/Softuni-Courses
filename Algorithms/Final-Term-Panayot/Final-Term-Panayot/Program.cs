namespace Algorithms_Final_Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] array = new decimal[3];

            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal num3 = decimal.Parse(Console.ReadLine());

            array[0] = num1;
            array[1] = num2;
            array[2] = num3;

            BubbleSort(array);


            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void BubbleSort(decimal[] array)
        {

            for (int f = 0; f < array.Length - 1; f++)
            {
                bool swapped = false;

                for (int i = 0; i < array.Length - 1 - f; i++)
                {

                    if (array[i] < array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }


                if (!swapped)
                    break;
            }
        }

        static void Swap(decimal[] array, int a, int b)
        {
            decimal temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
