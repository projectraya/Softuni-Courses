using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public interface IFish
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }

        public void Eat();
        
    }
}
