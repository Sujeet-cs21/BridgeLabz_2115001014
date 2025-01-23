using System;

class NaturalNumberCheck
{
    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a natural number
        if (number > 0)
        {
            // Calculate the sum of n natural numbers
            int sum = number * (number + 1) / 2;

            // Display the result
            Console.WriteLine("The sum of " + number + " natural numbers is " + sum);
        }
        else
        {
            // Display the result
            Console.WriteLine("The number " + number + " is not a natural number.");
        }
    }
}
