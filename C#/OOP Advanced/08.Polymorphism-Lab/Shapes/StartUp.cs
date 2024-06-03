namespace Shapes
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(3);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.Draw());

            Shape rect = new Rectangle(4, 5);
            Console.WriteLine(rect.CalculateArea()); 
            Console.WriteLine(rect.CalculatePerimeter()); 
            Console.WriteLine(rect.Draw()); 
            
        }
    }
}
