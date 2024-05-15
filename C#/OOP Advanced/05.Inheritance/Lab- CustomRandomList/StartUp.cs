namespace CustomRandomList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            RandomList strings = new RandomList();
            strings.Add("Bond");
            strings.Add("Ivan");
            strings.Add("James");

            Console.WriteLine(strings.Count);
            Console.WriteLine(strings.RandomString());
            Console.WriteLine(strings.Count);
            
        }
    }
}
