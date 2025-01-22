using System;

class ConvertDistance
{
    static void Main(string[] args)
    {
        double distanceInKm = 10.8;
        double distanceInMiles = distanceInKm / 1.6;

        Console.WriteLine("The marathon distance in miles is "+distanceInMiles+".");
    }
}