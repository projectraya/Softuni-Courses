using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class JuniorEmployee : Employee
    {
        public JuniorEmployee(string firstName, string lastName) : base(firstName, lastName)
        {
            Salary = 900;
            Department = "Junior";
        }

        public override decimal GetSalary()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Department} engineer.";
        }
    }
}
