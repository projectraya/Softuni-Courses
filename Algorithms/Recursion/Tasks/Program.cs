namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = PrintNatural(1, 10);
            Console.WriteLine(result);
        }
        static int PrintNatural(int a, int b)
        {
            if(a > b)
            {
                return a;
            }

            Console.Write(a + " ");
            return PrintNatural(a + 1, b);
            
            
        }
    }
}
