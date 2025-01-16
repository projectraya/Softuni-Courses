namespace PersonInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string bd = Console.ReadLine();

            IPerson person = new Citizen(name, age, id, bd);
            IIdentifiable person1 = new Citizen(name, age, id, bd);
            IBirthable person2 = new Citizen(name, age, id, bd);

            //Citizen citizen = new Citizen(name, age, id, bd);

            Console.WriteLine(person1.Id);
            Console.WriteLine(person2.Birthdate);
            //Console.WriteLine(citizen.Name + citizen.Age + citizen.Id + citizen.Birthdate);
        }
    }
}
