using System;

class AthleteRun
{
    static void Main(string[] args)
    {
        Console.Write("length of side1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("length of side2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("length of side3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;

        double targetDistance = 5000;

        double rounds = targetDistance / perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " 
                          + Math.Ceiling(rounds) + " to complete 5 km.");
    }
}
