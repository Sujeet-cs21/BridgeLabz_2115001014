using System;

class ReverseArray
{
    static void Main(string[] args)
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize variables
        int tempNumber = number;
        int count = 0;

        // Find the number of digits in the number
        while (tempNumber != 0)
        {
            count++;
            tempNumber /= 10;
        }

        // Create an array to store digits of the number
        int[] digits = new int[count];
        int index = 0;

        // Store the digits in the array
        tempNumber = number; // Reset the temp number to the original value
        while (tempNumber != 0)
        {
            digits[index] = tempNumber % 10;  // Extract the last digit
            tempNumber /= 10; // Remove the last digit from the number
            index++;
        }

        // Display the digits in reverse order
        Console.WriteLine("The digits of the number in reverse order are:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(digits[i] + " ");
        }
    }
}
