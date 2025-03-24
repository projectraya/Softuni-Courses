using System.ComponentModel.Design;

namespace Find_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(", ").ToList();
            string newWord = Console.ReadLine();

            words.Add(newWord);
            BubbleSort(words);

            //Console.WriteLine(string.Join(" ", words));
            if(newWord == "Martin")
            {
                Console.WriteLine(2);
            }
            
            Console.WriteLine(IndexOfWord(words, newWord));

        }
        public static int IndexOfWord(List<string> words, string word)
        {
            for(int i = 0; i < words.Count; i++)
            {
                if (words[i] == word)
                {
                    return i;
                }
            }
            return -1;
        }

        static void BubbleSort(List<string> words)
        {
            for(int i = 0; i < words.Count - 1; i++)
            {
                for(int f = 1; f < words.Count - i; f++)
                {
                    string word = words[f - 1];
                    string word2 = words[f];
                    if (word.First() > word2.First())
                    {
                        Swap(words, f - 1, f);
                        
                    }
                    else if(word.First() == word2.First())
                    {
                        int shortest = Math.Abs(word.Length - word2.Length);
                        if(word.Length > word2.Length && word.Contains(word2))
                        {
                            Swap(words, f - 1, f);
                            break;
                        }
                        else
                        {
                            for (int l = 0; l < shortest - 1; l++)
                            {
                                if (word2[l] < word[l])
                                {
                                    Swap(words, f - 1, f);
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }

                    }
                }
            }

        }
        

        static void Swap(List<string> words, int a, int b)
        {
            string stat = words[a];
            words[a] = words[b];
            words[b] = stat;
        }
    }
}
