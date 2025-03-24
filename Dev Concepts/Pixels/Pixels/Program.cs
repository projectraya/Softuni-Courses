using System.Drawing;
using System;
using System.Drawing.Imaging;
namespace Pixels
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 100;
            int height = 100;

            // Create a new bitmap with the given width and height
            Bitmap bitmap = new Bitmap(width, height);

            // Loop through every pixel in the image
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // If in the top half, color it red
                    if (y < height / 2)
                        bitmap.SetPixel(x, y, Color.Red);
                    else // Otherwise, color it blue
                        bitmap.SetPixel(x, y, Color.Blue);
                }
            }

            // Save the image to a file
            bitmap.Save("bitmap_example.bmp");

            Console.WriteLine("Bitmap image saved as 'bitmap_example.bmp'!");
        }
    }
}