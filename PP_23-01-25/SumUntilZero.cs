using System;

class SumUntilZero
{
    static void Main(string[] args)
    {
        double total = 0.0; // Initialize total to 0
        double userInput;  // Variable to store user input

        Console.WriteLine("Enter numbers to add to the total. Enter 0 to stop:");

        // Use a while loop to calculate the sum until the user enters 0
        while (true)
        {
            Console.Write("Enter a number: ");
            userInput = Convert.ToDouble(Console.ReadLine());

            if (userInput == 0) // Exit condition
                break;

            total += userInput; // Add user input to the total
        }

        // Display the total sum
        Console.WriteLine("The total sum of numbers entered is: " + total);
    }
}
