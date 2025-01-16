using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Sandbox
{
     public class Bird : Animal
    {
        public bool canFly = false;
        public Bird(string species, int friends, bool canFly) : base(species, friends)
        {

            canFly = canFly;
        }

        public override int Friends { get; set; }

        public override void Walk()
        {
            Console.WriteLine($"{Species} is walking...") ;
        }
    }
}
