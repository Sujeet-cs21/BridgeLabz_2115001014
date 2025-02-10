using System;
using System.Collections.Generic;

namespace PP_10_02_25
{
    // Abstract class Vehicle
    abstract class Vehicle1
    {
        public string VehicleId { get; private set; }
        public string DriverName { get; private set; }
        public double RatePerKm { get; private set; }

        protected Vehicle1(string vehicleId, string driverName, double ratePerKm)
        {
            VehicleId = vehicleId;
            DriverName = driverName;
            RatePerKm = ratePerKm;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle ID: " + VehicleId + ", Driver: " + DriverName + ", Rate per Km: " + RatePerKm);
        }
    }

    // Interface IGPS
    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }

    // Car class
    class Car1 : Vehicle1, IGPS
    {
        private string CurrentLocation;

        public Car1(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {
            CurrentLocation = "Unknown";
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            CurrentLocation = newLocation;
        }
    }

    // Bike class
    class Bike1 : Vehicle1, IGPS
    {
        private string CurrentLocation;

        public Bike1(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {
            CurrentLocation = "Unknown";
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm * 0.8; // Discounted rate for bikes
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            CurrentLocation = newLocation;
        }
    }

    // Auto class
    class Auto : Vehicle1, IGPS
    {
        private string CurrentLocation;

        public Auto(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {
            CurrentLocation = "Unknown";
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm * 0.9; // Slight discount for autos
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            CurrentLocation = newLocation;
        }
    }

    class Class8
    {
        public static void Main8()
        {
            List<Vehicle1> vehicles = new List<Vehicle1>
        {
            new Car1("C001", "Driver1", 15),
            new Bike1("B001", "Rider", 10),
            new Auto("A001", "Driver2", 12)
        };

            double distance = 10;

            foreach (var vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();
                Console.WriteLine("Fare for " + distance + " km: " + vehicle.CalculateFare(distance));
            }
        }
    }

}
