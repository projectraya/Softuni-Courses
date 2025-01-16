using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public interface IDecoration
    {
        public int Comfort { get; set; }
        public decimal Price { get; set; }
    }
}
