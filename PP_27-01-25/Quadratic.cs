using System;

public class Quadratic
{
    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        // Calculate delta (discriminant)
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            // Two real and distinct roots
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            // One real root
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            // No real roots (delta < 0)
            return new double[0]; // Empty array signifies no real roots
        }
    }

    static void Main(string[] args)
    {
        // Take user input for a, b, and c
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Call the method to find roots
        double[] roots = FindRoots(a, b, c);

        // Output the results
        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("One real root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("Two real roots: " + roots[0] + " and " + roots[1]);
        }
    }
}
