using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheriting
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Sleep()
        {
            Console.WriteLine($"Zaspa. Picha e {this.ToString}.");
        }
        
    }

    class Student : Person
    {
        public string School { get; set; }
    }

    class Employee : Person
    {
        public string Company { get; set; }
    }

    class Teacher : Person
    {
        public string Subject { get; set; }
    }
}
