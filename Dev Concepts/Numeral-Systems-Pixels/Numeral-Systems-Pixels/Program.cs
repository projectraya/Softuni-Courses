using System.Text;

namespace Numeral_Systems_Pixels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //input number
            int p = int.Parse(Console.ReadLine()); //position


            int bitAtPositionP = (n >> p) & 1;

            Console.WriteLine(bitAtPositionP);
        }

    }
}
