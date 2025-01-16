using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_SpaResort
{
    public class Employee : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }

        public int EmployeeId { get; set; }

        public Employee(string fN, string lN, string dep, int id)
        {
            FirstName = fN;
            LastName = lN;
            Department = dep;
            EmployeeId = id;
        }
        public string StartWorkingDay()
        {
            return $"{FirstName} {LastName} with id {EmployeeId} starts a new working day in the department {Department}.";
        }
    }
}
