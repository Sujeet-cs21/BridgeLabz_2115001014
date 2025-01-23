using System;

class NaturalSum1
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a valid natural number.");
            return;
        }

        // Compute the sum using the formula: n * (n + 1) / 2
        int formulaSum = n * (n + 1) / 2;

        // Compute the sum using a for loop
        int loopSum = 0;
        for (int counter = 1;counter <= n;counter++)
        {
            loopSum += counter;
        }

        // Display the results
        Console.WriteLine("Sum using the formula: " + formulaSum);
        Console.WriteLine("Sum using the while loop: " + loopSum);

        // Verify if both results are the same
        if (formulaSum == loopSum)
        {
            Console.WriteLine("The results from both computations are same.");
        }
        else
        {
            Console.WriteLine("The results do not match.");
        }
    }
}
