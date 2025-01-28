using System;

class AthleteRun
{
	// Method to calculate the number of rounds the athlete will run
	static double CalculateRounds(double side1, double side2, double side3, double targetDistance)
	{
		double perimeter = side1 + side2 + side3;
		double rounds = targetDistance / perimeter;
		return Math.Ceiling(rounds);
	}

	// Main Method
    static void Main(string[] args)
    {
		// Input from user
        Console.Write("length of side1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("length of side2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("length of side3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());


        double targetDistance = 5000;

		//calling CalculateRounds method
        double rounds = CalculateRounds(side1, side2, side3, targetDistance);

		// Output
        Console.WriteLine("The total number of rounds the athlete will run is " 
                        + rounds + " to complete 5 km.");
    }
}
