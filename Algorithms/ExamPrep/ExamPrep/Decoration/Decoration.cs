using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public abstract class Decoration : IDecoration
    {
        public int Comfort { get; set; }
        public decimal Price { get; set; }

        public Decoration(int comfort, decimal price)
        {
            Comfort = comfort;
            Price = price;
        }
    }
}
