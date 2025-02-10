using System;
using System.Collections.Generic;

namespace PP_10_02_25
{
    // Abstract class Vehicle
    abstract class Vehicle
    {
        public string VehicleNumber { get; private set; }
        public string Type { get; private set; }
        protected double RentalRate;

        public Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
        }

        public abstract double CalculateRentalCost(int days);
        public abstract double CalculateInsurance(int days);

        public void DisplayDetails(int days)
        {
            double totalCost = CalculateRentalCost(days) + CalculateInsurance(days);
            Console.WriteLine("Vehicle Number: " + VehicleNumber + ", Type: " + Type + ", Total Cost: " + totalCost);
        }
    }

    // Interface IInsurable
    interface IInsurable
    {
        double CalculateInsurance(int days);
        string GetInsuranceDetails();
    }

    // Car class
    class Car : Vehicle, IInsurable
    {
        public Car(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Car", rentalRate) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public override double CalculateInsurance(int days)
        {
            return RentalRate * 0.1 * days;
        }

        public string GetInsuranceDetails()
        {
            return "Insurance: 10% of rental cost";
        }
    }

    // Bike class
    class Bike : Vehicle, IInsurable
    {
        public Bike(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Bike", rentalRate) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public override double CalculateInsurance(int days)
        {
            return RentalRate * 0.05 * days;
        }

        public string GetInsuranceDetails()
        {
            return "Insurance: 5% of rental cost";
        }
    }

    // Truck class
    class Truck : Vehicle, IInsurable
    {
        public Truck(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Truck", rentalRate) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public override double CalculateInsurance(int days)
        {
            return RentalRate * 0.15 * days;
        }

        public string GetInsuranceDetails()
        {
            return "Insurance: 15% of rental cost";
        }
    }

    class Class3
    {
        public static void Main3()
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("123qwe", 50),
                new Bike("456asd", 20),
                new Truck("789zxc", 100)
            };

            int rentalDays = 10;
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayDetails(rentalDays);
            }
        }
    }
}
