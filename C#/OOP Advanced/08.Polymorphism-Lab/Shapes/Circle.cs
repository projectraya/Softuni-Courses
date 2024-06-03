using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private int radius;

        public int Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }
        public Circle(int r)
        {
            this.Radius = r;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * this.Radius;
        }
        public override string Draw()
        {
            return base.Draw() + "I AM A CIRCLE!";
        }

    }
}
