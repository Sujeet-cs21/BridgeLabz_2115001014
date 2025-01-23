using System;

class ArmstrongNumber
{
    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Storing the original number for comparison later
        int originalNumber = number;
        
        int sum = 0;
        
        // Using a while loop to extract digits of the number
        while (number != 0)
        {
            // Extract the last digit of the number
            int digit = number % 10;

            // Calculate the cube of the digit and add it to sum
            sum += digit * digit * digit;

            // Remove the last digit by dividing the number by 10
            number = number / 10;
        }
        
        // Check if the sum of cubes equals the original number
        if (sum == originalNumber)
        {
            Console.WriteLine(originalNumber + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not an Armstrong number.");
        }
    }
}
