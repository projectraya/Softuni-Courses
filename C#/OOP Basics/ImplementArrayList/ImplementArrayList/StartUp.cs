using System;

namespace ImplementArrayList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            CustomArrayList people = new CustomArrayList();
            people.Insert('4', 3);
            people.Add('9');

            Console.WriteLine(people[0]);

        }
    }
}
