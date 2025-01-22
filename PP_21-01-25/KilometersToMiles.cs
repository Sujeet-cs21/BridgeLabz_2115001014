using System;

class KilometersToMiles
{
    static void Main(string[] args)
    {
      
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        double miles = km / 1.6;

        Console.WriteLine("The total miles is " + miles.ToString("F2") +" miles for the given " + km.ToString("F2") + " km");
    }
}