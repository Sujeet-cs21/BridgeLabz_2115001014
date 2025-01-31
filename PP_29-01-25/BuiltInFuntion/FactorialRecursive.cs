using System;

public class FactorialRecursive
{
    // Method to get input from the user
    public static int GetInput()
    {
        Console.Write("Enter a non-negative integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Please enter a non-negative integer.");
            return GetInput();
        }
        return number;
    }

    // Method to calculate the factorial of a number
    public static int CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1; // Base case
        }
        else
        {
            return n * CalculateFactorial(n - 1); // Recursive step
        }
    }

    // Method to display the result
    public static void DisplayResult(int number, int factorial)
    {
        Console.WriteLine("The factorial of " + number + " is " + factorial + ".");
    }

    // main method
    public static void Main(string[] args)
    {
        int number = GetInput();
        int factorial = CalculateFactorial(number);
        DisplayResult(number, factorial);
    }
}