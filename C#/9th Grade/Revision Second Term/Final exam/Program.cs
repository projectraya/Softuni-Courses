using System;
using System.Linq;
using System.Text;

namespace Final_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string[] command = Console.ReadLine().Split("<->").ToArray();
            string com = command[0];

            string result = message;

            while (command[0] != "Read")
            {
                if(command[0] == "Space")
                {
                    int index = int.Parse(command[1]);
                    result = result.Insert(index, " ");
                }
                else if(command[0] == "Backward")
                {
                    string toChange = command[1];
                    string backwarded = "";
                    if (message.Contains(toChange))
                    {
                        backwarded = Reversed(toChange);
                        result = result.Replace(toChange, backwarded).ToString();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(command[0] == "ReplaceAll")
                {
                    

                    char old = char.Parse(command[1]);
                    char newOne = char.Parse(command[2]);

                    //TODO - replace for all occurances
                    foreach(char c in result)
                    {
                       result = result.Replace(old, newOne).ToString();
                    }
                    
                }
                command = Console.ReadLine().Split("<->").ToArray();
            }

            Console.WriteLine($"You have a secret text message: {result}");

            static string Reversed(string word)
            {
                StringBuilder result = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result.Append(word[i]);
                }

                return result.ToString();
            }
        }
    }
}
