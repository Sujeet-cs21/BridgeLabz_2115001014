using System;

class CarRental
{
    public string customerName ;
    public string carModel ;
    public int rentalDays ;
    public double dailyRate ;

    // Default constructor
    public CarRental()
    {
        customerName = "Person1";
        carModel = "car1";
        rentalDays = 1;
        dailyRate = 50.0;
    }

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.dailyRate = dailyRate;
    }

    public double CalculateTotalCost()
    {
        return rentalDays * dailyRate;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Rental Days: " + rentalDays);
        Console.WriteLine("Daily Rate: $" + dailyRate);
        Console.WriteLine("Total Cost: $" + CalculateTotalCost());
        Console.WriteLine("-----------------");
    }
}

class Program
{
    static void Main()
    {
        CarRental rental1 = new CarRental(); // Default constructor
        CarRental rental2 = new CarRental("Person2", "car2", 5, 40.0); // Parameterized constructor
        rental1.DisplayInfo();
        rental2.DisplayInfo();
    }
}
