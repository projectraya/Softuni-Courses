using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08.Generics_Exercise_2
{
    public class Tuple<T, V>
    {
        private object item1;
        private object item2;

        public object Item1
        {
            get { return this.item1; }
            set { this.item1 = value; }
        }

        public object Item2
        {
            get { return this.item2; }
            set { this.item2 = value; }
        }

        public void Print()
        {
            Console.WriteLine(this.Item1 + " -> " + this.Item2);
        }
    }
}
