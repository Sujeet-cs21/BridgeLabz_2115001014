using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is greater than 1
        if (number <= 1)
        {
            Console.WriteLine("The number " + number + " is not a prime number.");
            return;
        }

        // Assume the number is prime until proven otherwise
        bool isPrime = true;

        // Loop from 2 to the square root of the number
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) // If divisible by any number other than 1 and itself
            {
                isPrime = false;
                break;
            }
        }

        // Print the result
        if (isPrime)
        {
            Console.WriteLine("The number " + number + " is a prime number.");
        }
        else
        {
            Console.WriteLine("The number " + number + " is not a prime number.");
        }
    }
}
