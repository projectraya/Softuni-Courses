using System;

namespace candy
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();
            string size = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double final = 0.00;

            

            switch (color)
            {
                case "Red":

                    if(size == "Small")
                    {
                        final = 1.5 * count;

                    }else if(size == "Medium")
                    {
                        final = 2.2 * count;

                    }
                    else if(size == "Large")
                    {
                        final = 3.7 * count;
                    } break;
                
                case "Blue":

                    if (size == "Small")
                    {
                        final = 1.3 * count;

                    }
                    else if (size == "Medium")
                    {
                        final = 1.8 * count;

                    }
                    else if (size == "Large")
                    {
                        final = 2.1 * count;
                    }
                    break;


                case "Green":
                    
                    if (size == "Small")
                    {
                        final = 2.5 * count;

                    }
                    else if (size == "Medium")
                    {
                        final = 3.6 * count;

                    }
                    else if (size == "Large")
                    {
                        final = 5.2 * count;
                    }
                    break;

                    
            }

            if(size == "Medium")
            {
                final *= 0.95;
            }

            if(size == "Large" && color == "Green" && count >= 5)
            {
                final *= 0.75;
            };

            if(final > 30)
            {
                final *= 0.9;
            };

            Console.WriteLine($"You bought {count} boxes of {color} candy for {final:F2}lv.");
        }
    }
}
