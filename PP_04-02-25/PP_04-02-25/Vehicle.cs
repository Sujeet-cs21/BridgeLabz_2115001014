using System;

namespace PP_04_02_25
{
    class Vehicle
    {
        // Static variable shared by all vehicles
        public static double RegistrationFee = 500.0;

        // Readonly variable for Registration Number
        public readonly string RegistrationNumber;

        // Vehicle details
        public string OwnerName;
        public string VehicleType;

        // Constructor
        public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
        {
            // Using 'this' to initialize fields
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
            this.RegistrationNumber = RegistrationNumber;
        }

        // Static method to update registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine("Registration fee updated");
            Console.WriteLine("********************");
        }

        // Method to display vehicle details
        public void DisplayVehicleDetails()
        {
            // Using 'is' operator to check instance type
            if (this is Vehicle)
            {
                Console.WriteLine("Owner Name: " + OwnerName);
                Console.WriteLine("Vehicle Type: " + VehicleType);
                Console.WriteLine("Registration Number: " + RegistrationNumber);
                Console.WriteLine("Registration Fee: " + RegistrationFee);
                Console.WriteLine("********************");
            }
            else
            {
                Console.WriteLine("Invalid vehicle object.");
            }
        }
        public static void RunVehicleClass()
        {
            // Creating vehicle instances
            Vehicle vehicle1 = new Vehicle("Owner1", "Car", "ABC123");
            Vehicle vehicle2 = new Vehicle("Owner2", "Bike", "XYZ789");

            // Display vehicle details
            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();

            // Update registration fee
            Vehicle.UpdateRegistrationFee(600.0);

            // Display updated vehicle details
            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();
        }
    }
}
