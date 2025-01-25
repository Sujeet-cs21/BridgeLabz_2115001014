using System;

class Factors
{
    static void Main(string[] args)
    {
        //user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize the max number of factors that can be stored in the array
        int maxFactors = 10;
        int[] factors = new int[maxFactors];
        int index = 0;

        //find factors of the number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) // Check if i is a factor of the number
            {
                // If the factors array is full, expand it
                if (index == maxFactors)
                {
                    // Double the size of the factors array
                    maxFactors *= 2;
                    int[] temp = new int[maxFactors];
                    Array.Copy(factors, temp, factors.Length); // Copy existing factors to the temp array
                    factors = temp; // Assign temp back to factors
                }

                factors[index++] = i; // Store the factor and increment the index
            }
        }

        // Display the factors
        Console.WriteLine("Factors of " + number + " are:");

        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}
