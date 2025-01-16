using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int height;
        private int width;


        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public Rectangle(int h, int w)
        {
            this.Height = h;
            this.Width = w;

        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.Width + this.Height);
        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override string Draw()
        {
            return base.Draw() + "I AM A RECTANGLE!";
        }
    }
}
