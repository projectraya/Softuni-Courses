namespace CompanyHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

           

            while (input[0] != "End")
            {
                string firstName = input[0];
                string lastName = input[1];

                switch (input.Length)
                {
                    case 3: //junior
                        JuniorEmployee junior = new JuniorEmployee(firstName, lastName);
                        Console.WriteLine(junior.ToString());
                        Console.WriteLine($"Receives a salary {junior.Salary:F0}.");
                        break;

                    case 4:
                        string department = input[2];
                        if (department == "Engineering")
                        {
                            int years = int.Parse(input[3]);
                            Engineer engineer = new Engineer(firstName, lastName, department, years);
                            Console.WriteLine(engineer.ToString());
                            Console.WriteLine($"Receives a salary {engineer.GetSalary():F0}.");

                        }
                        else if(department == "Sales")
                        {
                            decimal profit = decimal.Parse(input[3]);
                            SalesEmployee sales = new SalesEmployee(firstName, lastName, department, profit);
                            Console.WriteLine(sales.ToString());
                            Console.WriteLine($"Receives a salary {sales.GetSalary():F1}.");
                        
                        }
                        break;
                        
                }
                
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
