using System;

class HarshadNumber
{
    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Store the original number for later use and calculate the sum of its digits
        int originalNumber = number;
        int sum = 0;

        // Use a while loop to calculate the sum of digits
        while (number > 0)
        {
            // Extract the last digit and add it to the sum
            sum += number % 10;

            // Remove the last digit from the number
            number = number / 10;
        }

        // Check if the original number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            Console.WriteLine(originalNumber + " is a Harshad Number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is Not a Harshad Number.");
        }
    }
}
