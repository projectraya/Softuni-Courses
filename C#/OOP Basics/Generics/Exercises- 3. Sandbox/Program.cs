namespace _08.Generics_Exercise_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> items = new List<int>();

            for(int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                items.Add(input);
            }

            string[] indexes = Console.ReadLine().Split().ToArray();
            int one = int.Parse(indexes[0]);
            int two = int.Parse(indexes[1]);

            
            
            
            Class.Print(items, one, two);
            
        }

        
    }
}
