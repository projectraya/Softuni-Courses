using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Engineer : Employee
    {
        public int YearsService { get; set; }
        public Engineer(string firstName, string lastName, string department, int years) : base(firstName, lastName)
        {
            YearsService = years;
            Department = department;
            Salary = 1300;
        }

        public override decimal GetSalary()
        {
            decimal sum = Salary + (90 * YearsService);
            return sum;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} from {Department} has {YearsService} years of service.";
        }
    }
}
