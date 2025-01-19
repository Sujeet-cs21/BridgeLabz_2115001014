//5. Convert Kilometers to Miles

using System;

class KmToMiles
{
    static void Main(string[] args)
    {
        Console.WriteLine("kilometers:");
        double km = double.Parse(Console.ReadLine());

        double miles = km * 0.621371;
        Console.WriteLine("The distance in miles is: " + miles);
    }
}
