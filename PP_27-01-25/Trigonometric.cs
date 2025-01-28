using System;

class Trigonometric
{
    // Method to calculate trigonometric functions
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle from degrees to radians
        double radians = angle * (Math.PI / 180);

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the results as an array
        return new double[] { sine, cosine, tangent };
    }

    static void Main(string[] args)
    {
        // Get the angle in degrees from the user
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Calling CalculateTrigonometricFunctions method
        double[] results = CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine("Sine: " + results[0]);
        Console.WriteLine("Cosine: " + results[1]);
        Console.WriteLine("Tangent: " + results[2]);
    }
}
