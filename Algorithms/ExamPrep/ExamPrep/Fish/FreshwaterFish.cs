using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public class FreshwaterFish : Fish
    {
        public FreshwaterFish(string name, string species, decimal price) : base(name, species, price)
        {
            Size = 3;
        }

        public override void Eat()
        {
            Size += 3;
        }
    }
}
