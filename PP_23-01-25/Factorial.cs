using System;

class Factorial
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer to find its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate input
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers. Please enter a positive integer.");
            return;
        }

        int factorial = 1; // Initialize factorial to 1
        int counter = 1;   // Start counter from 1

        // Compute factorial using while loop
        while (counter <= number)
        {
            factorial *= counter;
            counter++;
        }

        // Output the factorial
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}
