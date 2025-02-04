using System;

class Vehicle
{
    //instance variables
    public string ownerName ;
    public string vehicleType ;

    //static variable
    public static double registrationFee = 100.0;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Static method to update registration fee
    public static void UpdateRegistrationFee(int newFee)
    {
        registrationFee = newFee;
        Console.WriteLine("Registration fee Updated" );
        Console.WriteLine("-----------------");
    }

    // Method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: $" + registrationFee);
        Console.WriteLine("-----------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create vehicle objects
        Vehicle vehicle1 = new Vehicle("Owner1", "Vehicle1");

        // Display vehicle details
        vehicle1.DisplayVehicleDetails();

        // Update registration fee
        Vehicle.UpdateRegistrationFee(200);

        // Display vehicle details
        vehicle1.DisplayVehicleDetails();
    }
}
