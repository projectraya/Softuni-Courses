using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Exam_UnitTesting_1
{
    public class Customer
    {
        //private int customerId;
        //private string name;
        //private int age;
        //private string email;
        //private int bonusPoints;

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int BonusPoints { get; set; }

        public Customer(int id, string name, int age, string email)
        {
            this.CustomerId = id;
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.BonusPoints = 10;
        }

        public void AddBonusPoints(int points)
        {
            this.BonusPoints = this.BonusPoints + points;
            Console.WriteLine($"You have {this.BonusPoints} bonus points.");
        }

        public void ExchangePoints(int points)
        {
            if(this.BonusPoints < points)
            {
                Console.WriteLine("You do not have enough bonus points.");
            }
            else
            {
                this.BonusPoints = this.BonusPoints - points;
                Console.WriteLine($"You have {this.BonusPoints} points left.");
            }
            

        }
    }
}
