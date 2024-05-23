using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_SpaResort
{
    public class Guest : Customer
    {
        public Guest(string firstName, string lastName) : base(firstName, lastName)
        { }
        

        public string NewGuest()
        {
            return $"Mr/Ms/Mrs {FirstName} {LastName} registers as a guest.";
        }
    }
}
