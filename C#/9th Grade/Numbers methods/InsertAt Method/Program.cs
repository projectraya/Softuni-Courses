using System;

namespace links
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "a", "s", "d", "f" };
            string[] result = InsertAt(words, 2, "w");
            Console.WriteLine(string.Join(" ", result));
        }
        static string[] InsertAt(string[] input, int index, string word)
        {
            string[] result = new string[input.Length + 1];
            bool isInserted = false;
            for(int i = 0; i < result.Length; i++)
            {
                
                if(i != index)
                {
                    result[i] = input[i];
                }
                else
                {
                    result[index] = word;
                    isInserted = true;
                }
                if (isInserted)
                {
                    for(int j = 0; j < result.Length; j++)
                    {
                        result[i] = input[i - 1];
                        
                    }
                    break;
                }
            }

            return result;
        }
    }
}
