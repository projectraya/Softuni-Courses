using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        public string Make;
        public string Model;
        public int HorsePower;
        public string RegistrationNumber;

        public Car(string make, string model, int hp, string registration)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = hp;
            this.RegistrationNumber = registration;


        }
        public override string ToString()
        {
            return $"Make: {this.Make} \nModel: {this.Model}\nHorsePower: {this.HorsePower}\nRegistrationNumber: {this.RegistrationNumber}";
        }
    }
}
