using System;

class Factor
{
    // Method to find the factors of a number and store them in an array
    public static int[] FindFactors(int number)
    {
        //loop to count the factors
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Initializing the array to store the factors
        int[] factors = new int[count];
        int index = 0;

        //loop to store the factors in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // Method to find the sum of the factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors
    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the sum of squares of the factors
    public static double SumOfSquaresOfFactors(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    static void Main(string[] args)
    {
        // Get the number from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Find the factors of the number
        int[] factors = FindFactors(number);

        // Display the factors
        Console.WriteLine("Factors of " + number + ": ");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        // Calculate and display the sum of factors
        int sum = SumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sum);

        // Calculate and display the product of factors
        long product = ProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + product);

        // Calculate and display the sum of squares of factors
        double sumOfSquares = SumOfSquaresOfFactors(factors);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }
}
