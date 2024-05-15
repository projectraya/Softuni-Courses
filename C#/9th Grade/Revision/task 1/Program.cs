using System;

namespace Pregovor9klas
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            
            if(num < 18)
            {
                Console.WriteLine($"Hello, I am {name} and I am not an adult yet.");
            }
            else
            {
                Console.WriteLine($"Hello, I am {name} and I am an adult for {num - 18} years now.");
            }

            //int num1 = 20;
            //Console.WriteLine(num1 / 3.0);
            //Console.WriteLine(num1 / 3f);



            //Console.WriteLine("Hello, I am " + name + " and I am " + num + " years old.");
            //string one = "Hello, I am ";
            //string two = " and I am ";
            //string three = " years old.";
            //Console.WriteLine(one + name + two + num + three);
            //Console.Write("hello I am {name}");
            //Console.Write("and I am");
        }
    }
}
