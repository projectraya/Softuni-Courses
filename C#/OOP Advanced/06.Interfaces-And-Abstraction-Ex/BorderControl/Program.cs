namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<string> idNumbers = new List<string>();


            while (input[0] != "End")
            {
                if (input.Length == 2)
                {

                    idNumbers.Add(input[1]);
                }
                else if (input.Length == 3)
                {

                    idNumbers.Add(input[2]);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            string endNumber = Console.ReadLine();



            foreach (string id in idNumbers)
            {
                if (id.EndsWith(endNumber))
                {
                    Console.WriteLine(id);
                }

            }
        }
    }
}
