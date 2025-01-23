using System;

class GreatestFactor
{
    static void Main(string[] args)
    {
        // Taking user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize the greatest factor to 1
        int greatestFactor = 1;

        // Loop from number-1 down to 1
        for (int i = number - 1; i >= 1; i--)
        {
            // Check if the number is divisible by i
            if (number % i == 0)
            {
                // Assign the greatest factor
                greatestFactor = i;
                break; // Exit the loop
            }
        }

        // Display the greatest factor
        Console.WriteLine("The greatest factor of " + number + "is " + greatestFactor);
    }
}
