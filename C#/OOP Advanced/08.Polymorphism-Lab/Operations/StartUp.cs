namespace Operations
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations operations = new MathOperations();
            Console.WriteLine(operations.Add(1, 2));
            Console.WriteLine(operations.Add(2.3, 3.5, 11.2));
            Console.WriteLine(operations.Add(3.1m, 2.1m, 5.1m));
        }
    }
}
