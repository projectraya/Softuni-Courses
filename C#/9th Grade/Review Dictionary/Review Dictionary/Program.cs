using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Review_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //second task
            
            List<string> words = Console.ReadLine().Split().Select(w => w.ToLower()).ToList();

            Dictionary<string, int> occurances = new Dictionary<string, int>();

            foreach(string word in words)
            {
                
                if (!occurances.Keys.Contains(word))
                {
                    occurances.Add(word, 1);
                }
                else
                {
                    occurances[word]++;
                }
                
            }
            

            foreach(KeyValuePair<string, int> pair in occurances)
            {
                if(pair.Value % 2 == 1)
                {
                    Console.Write(pair.Key + " ");
                }

            }

            
        }
    }
}
