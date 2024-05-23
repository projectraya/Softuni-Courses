using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_SpaResort
{
    public class Member : Customer
    {
        public int MembershipId { get; set; }
        public Member(string firstName, string lastName, int id) : base(firstName, lastName)
        {
            MembershipId = id;
        }

        public string GetMemberCard(string freeAccess)
        {
            return $"Member {FirstName} {LastName} with membership number {MembershipId} gets free access to the {freeAccess}.";
        }
    }
}
