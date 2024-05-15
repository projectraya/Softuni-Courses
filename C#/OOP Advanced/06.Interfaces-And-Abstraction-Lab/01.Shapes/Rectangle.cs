using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Draw()
        {
            Drawline(this.Width, '*', '*');
            for(int i = 1; i < this.Height; ++i)
            {
                Drawline(this.Width, '*', ' ');
            }
            Drawline(this.Width, '*', '*');
        }
        private void Drawline(int width, char end, char mid)
        {
            Console.Write(end);
            for(int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
