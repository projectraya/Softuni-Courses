using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public class Ornament : Decoration
    {
        public int Comfort { get; set; }
        public decimal Price { get; set; }
        public Ornament() : base(1, 5)
        {
            Comfort = 1;
            Price = 5;
        }
        

    }
}
