//5. Volume of a Cylinder

using System;

class VolumeOfCylinder
{
    static void Main(string[] args)
    {
        Console.WriteLine("radius:");
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("height:");
        double h = double.Parse(Console.ReadLine());

        double v = Math.PI * Math.Pow(r, 2) * h;
        Console.WriteLine("volume: " + v);
    }
}
