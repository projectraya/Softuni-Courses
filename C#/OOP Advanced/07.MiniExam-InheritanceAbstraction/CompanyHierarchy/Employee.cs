using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public abstract class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public abstract decimal GetSalary();

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            

        }
    }
}
