using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public class Plant : Decoration
    {
        public Plant() : base(5, 10)
        {
            Comfort = 5;
            Price = 10;
        }
    }
}
