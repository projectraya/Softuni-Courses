using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class SalesEmployee : Employee
    {
        public decimal Profits { get; set; }
        
        public SalesEmployee(string firstName, string lastName, string dep, decimal profit)
            : base(firstName, lastName)
        {
            Profits = profit;
            Department = dep;
            Salary = 1000;
        }
        public override decimal GetSalary()
        {
            decimal sum = (Profits * 10 / 100) + Salary;
            return sum;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} from {Department} has {Profits} profits.";
        }
    }
}
