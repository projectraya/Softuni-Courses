using System;

namespace gender
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            if(gender == "f")
            {
                if(age < 16)
                {
                    Console.WriteLine("Miss" + name);
                }
                else
                {
                    Console.WriteLine("Ms." + name);
                }
            }
            else if(age < 16)
            {
                Console.WriteLine("Master" + name);
            }
            else
            {
                Console.WriteLine("Mr." + name);
            }
        }
    }
}
