using System;

class StopWhenZero
{
    static void Main(string[] args)
    {
        // Define an array to store up to 10 numbers
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter up to 10 numbers , enter 0 or a -ve number to stop:");

        while (true)
        {
            // Take user input
            Console.Write("Enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Check if input is 0 or negative
            if (userInput <= 0)
            {
                Console.WriteLine("stop! 0 or -ve number entered");
                break;
            }

            // Check if array is full
            if (index >= 10)
            {
                Console.WriteLine("stop! limit of 10 numbers reached");
                break;
            }

            // Store the number in the array and increment index
            numbers[index] = userInput;
            index++;
        }

        // Calculate total and display numbers
        Console.WriteLine("\nentered numbers are:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        // Display the total
        Console.WriteLine("\nThe sum of all numbers entered is: " + total);
    }
}
