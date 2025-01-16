namespace Blanc_vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //what is the most basic version of the problem
            int[] vector = new int[3];
            //0 0 0 0 0 0 0 0
            //0 0 0 0 0 0 0 1
            //0 0 0 0 0 0 1 0
            //0 0 0 0 0 0 1 1
            //0 0 0 0 0 1 0 0
            Gen01(0, vector);
        }
        static void Gen01(int index, int[] vector)
        {
            if (index >= vector.Length) //if index == 4 meaning we make 4 for-loops
            {
                Console.WriteLine(string.Join(" ", vector));
            }
                
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i; //zadava cifra
                    Gen01(index + 1, vector); //vliza v novo 
                }
            }
        }
    }
}
