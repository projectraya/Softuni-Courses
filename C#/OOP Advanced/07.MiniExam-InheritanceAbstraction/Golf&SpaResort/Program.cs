namespace Golf_SpaResort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            List<Member> members = new List<Member>();

            while (input[0] != "End")
            {
                string firstName = input[0];
                string lastName = input[1];

                if (input.Length == 2) //guest
                {
                    Guest currentGuest = new Guest(firstName, lastName);
                    Console.WriteLine(currentGuest.NewGuest()); 
                }
                else if(input.Length == 3) //member
                {

                    int id = int.Parse(input[2]);
                    Member member = new Member(firstName, lastName, id);
                    members.Add(member);

                    if(members.Count % 2 == 0)
                    {
                        Console.WriteLine(member.GetMemberCard("fitness")); 
                    }
                    else
                    {
                        Console.WriteLine(member.GetMemberCard("spa"));
                    }

                }
                else if(input.Length == 4) // emp
                {
                    string department = input[2];
                    int id = int.Parse(input[3]);
                    Employee employee = new Employee(firstName, lastName, department, id);
                    Console.WriteLine(employee.StartWorkingDay()); 
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
