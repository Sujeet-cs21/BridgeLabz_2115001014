using System;

class OddEvenNumbers
{
    static void Main(string[] args)
    {
        //user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a valid natural number
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return; // Exit the program
        }

        //arrays for even and odd numbers
        int[] evenNumbers = new int[number / 2 + 1];
        int[] oddNumbers = new int[number / 2 + 1];

        //index variables for both arrays
        int evenIndex = 0, oddIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0) // Check if the number is even
            {
                evenNumbers[evenIndex++] = i;
            }
            else // Otherwise, the number is odd
            {
                oddNumbers[oddIndex++] = i;
            }
        }

        // Print the even numbers array
        Console.WriteLine("\nEven numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }

        // Print the odd numbers array
        Console.WriteLine("\nOdd numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
    }
}
