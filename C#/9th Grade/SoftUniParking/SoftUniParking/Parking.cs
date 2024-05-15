using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        public List<Car> Cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.Cars = new List<Car>(capacity);
        }

        public string AddCar(Car car)
        {

            foreach (Car currentCar in this.Cars)
            {
                if (car.RegistrationNumber == currentCar.RegistrationNumber)
                {

                    return "Car with that registration number already exists!";

                }

            }

            if (this.capacity <= this.Cars.Count)
            {

                return "Parking is full!";

            }
            else
            {
                this.Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";

            }


        }

        public string RemoveCar(string number)
        {
            foreach (Car currentCar in this.Cars)
            {
                if (number == currentCar.RegistrationNumber)
                {
                    this.Cars.Remove(currentCar);
                    return $"Successfully removed {number}";

                }

            }
            return "Car with that registration number, doesn't exist!";
        }

        public Car GetCar(string registration)
        {
            foreach (Car currentcar in this.Cars)
            {
                if (currentcar.RegistrationNumber == registration)
                {
                    return currentcar;

                }

            }
            return null;

        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (Car currentCar in this.Cars)
            {
                foreach (string number in RegistrationNumbers)
                {
                    if (currentCar.RegistrationNumber == number)
                    {
                        this.Cars.Remove(currentCar);
                        Console.WriteLine($"Sucess in removing {currentCar.RegistrationNumber}");
                        return;
                    }

                }


            }
        }
        public int Count
        {
            get { return this.Cars.Count; }

        }
    }
}
