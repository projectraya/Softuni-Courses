using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public class SaltwaterAquarium : Aquarium
    {
        public SaltwaterAquarium(string name) : base(name, 25)
        {
            Capacity = 25;
        }
    }
}
