using System;

class NaturalSum1
{
    // Method to find the sum of n natural numbers using recursion
    public static int SumOfNaturalNumbers(int n)
    {
        // Base case: sum of first 1 natural number is 1
        if (n == 1)
        {
            return 1;
        }
        // Recursive call
        return n + SumOfNaturalNumbers(n - 1);
    }

    // Method to find the sum of n natural numbers using the formula
    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a valid natural number
        if (n > 0)
        {
            // Compute the sum using recursion
            int sumRecursion = SumOfNaturalNumbers(n);
            
            // Compute the sum using the formula
            int sumFormula = SumUsingFormula(n);

            // Display the results and compare
            Console.WriteLine("Sum using recursion: " + sumRecursion);
            Console.WriteLine("Sum using the formula: " + sumFormula);

            if (sumRecursion == sumFormula)
            {
                Console.WriteLine("Both results are same.");
            }
            else
            {
                Console.WriteLine("The results do not match.");
            }
        }
        else
        {
            // If the user entered an invalid input
            Console.WriteLine("Please enter a valid natural number.");
        }
    }
}
