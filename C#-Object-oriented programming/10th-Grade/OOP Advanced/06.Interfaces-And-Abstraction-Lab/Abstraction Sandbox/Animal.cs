using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Sandbox
{
    public abstract class Animal
    {
        public string Species { get; set; }
        public abstract int Friends { get; set; }

        public abstract void Walk();
        public void Run()
        {
            Console.WriteLine($"{Species} is running...");
        }

        public Animal(string species, int friends)
        {
            Species = species;
            Friends = friends;
        }
        
    }
}
