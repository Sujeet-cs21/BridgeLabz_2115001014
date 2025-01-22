using System;

class EarthVolume
{
    static void Main(string [] args)
    {
        double radiusKm = 6378;

        double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        double radiusMiles = radiusKm * 0.6;
        double volumeMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

        Console.WriteLine("The volume of earth in cubic kilometers is " + volumeKm.ToString("F2") + " and cubic miles is " + volumeMiles.ToString("F2"));
    }
}
