using System;

namespace loops_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine(); //reads the command Go or End

            while(command == "Go")
            {
                string first = Console.ReadLine(); //reads 3 words
                string second = Console.ReadLine();
                string third = Console.ReadLine();

                string newWord = first + second + third; //connects them into one word
                Console.WriteLine(newWord); //writes the new word

                command = Console.ReadLine(); //reads a command again so the code continues
            }
            if(command == "End")
            {
                return; //breaks the code if the command is End
            }
        }
    }
}
