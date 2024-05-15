using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IDrawable
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            double rIn = this.Radius - 0.4; //2.6
            double rOut = this.Radius + 0.4; //3.4
            int countLine = 0;

            for(double y = this.Radius; y >= -this.Radius; y--) //y = 3; while 3>= -3; y-- // 6 times = 6 rows
            {
                for(double x = -this.Radius; x < rOut; x += 0.5) //x = -3; while -3 < 3.4; x+=0.5
                    //this loops 
                {
                    double value = x * x + y * y; //-2 * -2 + 2 * 2 == 4 + 4 = 8

                    if(value >= rIn * rIn && value <= rOut * rOut) //if 8 >= 6.76 and <= 11.56
                        //loop 1
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                        
                    }
                }
                
                Console.WriteLine();
                
            }

            
        }
    }
}
