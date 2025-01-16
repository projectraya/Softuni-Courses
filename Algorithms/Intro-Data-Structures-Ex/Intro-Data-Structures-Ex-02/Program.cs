using rm.Trie;
using static System.Net.Mime.MediaTypeNames;

namespace Intro_Data_Structures_Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string prefix = Console.ReadLine();

            ITrie trie = new Trie();
            

            foreach(string word in words)
            {
                trie.AddWord(word);
                
            }

            //first task
            Console.WriteLine(trie.Count());

            //second task
            Console.WriteLine(trie.UniqueCount());

            //third task
            IEnumerable<string> allWords = trie.GetWords();
            Console.WriteLine(string.Join(", ", allWords));

            //forth task
            string[] prefixWords = trie.GetWords(prefix).ToArray();
            Console.WriteLine(string.Join(", ", prefixWords));

            //fifth task
            trie.RemovePrefix(prefix);
            IEnumerable<string> changedTrie = trie.GetWords();
            Console.WriteLine(string.Join(", ", changedTrie));
        }
    }
}
