using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_And_Abstraction
{
    class Invoice : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Az sum faktura");
        }

        public void Hi()
        {
            Console.WriteLine("Heyoooo, az sum faktura");
        }
        void IPrintable.Print()
        {
            Console.WriteLine("Explicit print : Az sum faktura");
        }
    }
}
