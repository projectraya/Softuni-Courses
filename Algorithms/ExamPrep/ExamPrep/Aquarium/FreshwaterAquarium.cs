using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public class FreshwaterAquarium : Aquarium
    {
        public FreshwaterAquarium(string name) : base(name, 50)
        {
            Capacity = 50;
        }
    }
}
