using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }


    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }

    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing...");
        }
    }
}
