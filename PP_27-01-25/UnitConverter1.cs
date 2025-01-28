using System;

class UnitConverter1
{
    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }

    static void Main(string[] args)
    {
        // Example usage of the conversion methods

        // Convert yards to feet
        Console.Write("Enter distance in yards: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        double feet = ConvertYardsToFeet(yards);
        Console.WriteLine(yards + " yards is equal to " + feet + " feet.");

        // Convert feet to yards
        Console.Write("Enter distance in feet: ");
        double feetInput = Convert.ToDouble(Console.ReadLine());
        double yardsConverted = ConvertFeetToYards(feetInput);
        Console.WriteLine(feetInput + " feet is equal to " + yardsConverted + " yards.");

        // Convert meters to inches
        Console.Write("Enter distance in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        double inches = ConvertMetersToInches(meters);
        Console.WriteLine(meters + " meters is equal to " + inches + " inches.");

        // Convert inches to meters
        Console.Write("Enter distance in inches: ");
        double inchesInput = Convert.ToDouble(Console.ReadLine());
        double metersConverted = ConvertInchesToMeters(inchesInput);
        Console.WriteLine(inchesInput + " inches is equal to " + metersConverted + " meters.");

        // Convert inches to centimeters
        Console.Write("Enter distance in inches: ");
        double inchesForCm = Convert.ToDouble(Console.ReadLine());
        double cm = ConvertInchesToCentimeters(inchesForCm);
        Console.WriteLine(inchesForCm + " inches is equal to " + cm + " centimeters.");
    }
}
