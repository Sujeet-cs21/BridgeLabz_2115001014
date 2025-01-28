using System;

class SimpleInterest
{
	// Method to calculate Simple Interest
	static double CalculateSI(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

	// Main Method
    static void Main(string[] args)
    {

		// Input from user
        Console.Write("Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Time: ");
        double time = Convert.ToDouble(Console.ReadLine());
		
		// Calculate Simple Interest
        double simpleInterest = CalculateSI(principal, rate, time);

		// Output
        Console.WriteLine("The Simple Interest is " + simpleInterest.ToString("F2") + 
                    	" for Principal " + principal + ", Rate of Interest " + rate + 
                        " and Time " + time + " years.");
    }
}
