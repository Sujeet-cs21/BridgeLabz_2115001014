using System;

public class RandomNumberStats
{
    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] randomNumbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = rand.Next(1000, 10000); // Generates a 4-digit number
        }

        return randomNumbers;
    }

    // Method to find the average, min, and max value of an array
    public static double[] FindAverageMinMax(int[] numbers)
    {
        double[] result = new double[3];
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);  // Find minimum
            max = Math.Max(max, numbers[i]);  // Find maximum
        }

        // Calculate the average
        result[0] = sum / numbers.Length;
        result[1] = min;
        result[2] = max;

        return result;
    }

    // Main method
    public static void Main(string[] args)
    {
        // Generate an array of 5 random 4-digit numbers
        int size = 5;
        int[] randomNumbers = Generate4DigitRandomArray(size);

        // Display the random numbers
        Console.WriteLine("Generated 4-digit Random Numbers:");
        foreach (int num in randomNumbers)
        {
            Console.WriteLine(num);
        }

        // Find the average, min, and max values
        double[] stats = FindAverageMinMax(randomNumbers);

        // Display the results
        Console.WriteLine("\nStatistics:");
        Console.WriteLine("Average: " + stats[0]);
        Console.WriteLine("Minimum: " + stats[1]);
        Console.WriteLine("Maximum: " + stats[2]);
    }
}
