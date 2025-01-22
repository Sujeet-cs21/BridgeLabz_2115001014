using System;

class TripDetails
{
    static void Main(string[] args)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("distance between " + fromCity + " and " + viaCity + " : ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("distance between " + viaCity + " and " + toCity + " : ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("total time taken: ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = (fromToVia + viaToFinalCity) / timeTaken;

        Console.WriteLine("The results of the trip are: ");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Route: from " + fromCity + " via " + viaCity + " to " + toCity);
        Console.WriteLine("Total Distance: " + totalDistance.ToString("F2") + " miles");
        Console.WriteLine("Time Taken: " + timeTaken.ToString("F2") + " hours");
        Console.WriteLine("Average Speed: " + averageSpeed.ToString("F2") + " miles/hour");
    }
}
