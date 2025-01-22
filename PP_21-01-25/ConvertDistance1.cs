using System;

class ConvertDistance1
{
    static void Main(string[] args)
    {
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());


        double distanceInYards = distanceInFeet / 3;

        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine("The distance in feet is " + distanceInFeet + 
                          " while in yards is " + distanceInYards.ToString("F2") + 
                          " and in miles is " + distanceInMiles.ToString("F4"));
    }
}
