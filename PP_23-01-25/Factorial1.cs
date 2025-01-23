using System;

class Factorial1
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer to find its factorial: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Validate input
        if (n < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers. Please enter a positive integer.");
            return;
        }

        int factorial = 1; // Initialize factorial to 1

        // Compute factorial using for loop
        for (int counter=1; counter <= n; counter++)
        {
            factorial *= counter;
        }

        // Output the factorial
        Console.WriteLine("The factorial of " + n + " is: " + factorial);
    }
}
