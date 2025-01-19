//1. Calculate Simple Interest

using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        Console.WriteLine("Principal:");
        double p = double.Parse(Console.ReadLine());

        Console.WriteLine("Rate:");
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("Time:");
        double t = double.Parse(Console.ReadLine());

        double SI = (p * r * t) / 100;
        Console.WriteLine("SI: " + SI);
    }
}
