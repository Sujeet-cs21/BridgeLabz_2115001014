using System;

class HotelBooking
{
    public string guestName ;
    public string roomType ;
    public int nights ;

    // Default constructor
    public HotelBooking()
    {
        this.guestName = "Guest1";
        this.roomType = "Standard";
        this.nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Guest Name: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Nights: " + nights);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HotelBooking booking1 = new HotelBooking(); //Default constructor
        HotelBooking booking2 = new HotelBooking("Guest2", "Deluxe", 3); // Parameterized constructor
        HotelBooking booking3 = new HotelBooking(booking2); // Copy constructor

        booking1.DisplayInfo();
        Console.WriteLine("-----------------");
        booking2.DisplayInfo();
        Console.WriteLine("-----------------");
        booking3.DisplayInfo();
    }
}
