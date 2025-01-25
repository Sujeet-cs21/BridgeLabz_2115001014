using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate that the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Create a string array to store results
        string[] fizzBuzzArray = new string[number + 1];

        // Loop from 1 to the input number
        for (int i = 1; i <= number; i++)
        {
            // Check for multiples of both 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                fizzBuzzArray[i] = "FizzBuzz";
            }
            // Check for multiples of 3
            else if (i % 3 == 0)
            {
                fizzBuzzArray[i] = "Fizz";
            }
            // Check for multiples of 5
            else if (i % 5 == 0)
            {
                fizzBuzzArray[i] = "Buzz";
            }
            else
            {
                fizzBuzzArray[i] = i.ToString();
            }
        }

        // Print the results in the required format
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + fizzBuzzArray[i]);
        }
    }
}
