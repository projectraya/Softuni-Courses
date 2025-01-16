namespace Mini_Exam_UnitTesting_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            int id = int.Parse(input[0]);
            string name = input[1];
            int age = int.Parse(input[2]);
            string email = input[3];

            Customer customer = new Customer(id, name, age, email);

            string[] command = Console.ReadLine().Split(" ").ToArray();

            while (command[0] != "End")
            {
                if (command[0] == "Bonus")
                {
                    int points = int.Parse(command[2]);
                    customer.AddBonusPoints(points);
                }
                else if (command[0] == "Exchange")
                {
                    int points = int.Parse(command[1]);
                    customer.ExchangePoints(points);
                }
                command = Console.ReadLine().Split(" ").ToArray();
            }
            
        }
    }
}
