using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelConsumption;
        private double fuelQuantity;

        public Engine engine { get; set; }
        
        public Tire[] tires { get; set; }

        
       
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double result = (this.FuelQuantity - distance) * this.FuelConsumption;

            if(result > 0)
            {
                this.FuelQuantity = this.FuelQuantity - (this.FuelConsumption * distance);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            
        }

        public string WhoAmI()
        {
            string result = $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
            return result;
        }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fQ, double fC) : this(make, model, year)
        {
            FuelConsumption = fC;
            FuelQuantity = fQ;
        }

        public Car(string make, string model, int year, double fQ, double fC, Engine engine, Tire[] tires)
            : this(make, model, year, fQ, fC)
        {
            this.engine = engine;
            this.tires = tires;
        }
    }


}
