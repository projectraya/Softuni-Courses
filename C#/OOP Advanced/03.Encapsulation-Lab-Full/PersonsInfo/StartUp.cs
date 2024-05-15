namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                Person person = new Person(command[0], command[1]
                    , int.Parse(command[2])
                    , decimal.Parse(command[3]));

                persons.Add(person);
            }

            decimal bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
