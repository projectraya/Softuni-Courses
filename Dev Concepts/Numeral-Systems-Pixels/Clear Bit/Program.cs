namespace Clear_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //input number
            int p = int.Parse(Console.ReadLine()); //position

            int mask;
            int result;

            mask = (1 << p);
            mask = ~mask;

            result = (n & mask);

            Console.WriteLine(result);
        }
    }
}
