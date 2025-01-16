using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public class SaltwaterFish : Fish
    {
        public SaltwaterFish(string name, string species, decimal price) : base(name, species, price)
        {
            Size = 5;
        }

        public override void Eat()
        {
            Size += 2;
        }
    }
}
