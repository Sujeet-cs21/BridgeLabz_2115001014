using System;

class AbundantNumber
{
    static void Main()
    {
        // Taking user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        // Loop to find divisors and calculate their sum
        for (int i = 1; i < number; i++)
        {
            // Check if 'i' is a divisor of the number
            if (number % i == 0)
            {
                sum += i;  // Add divisor to sum
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            Console.WriteLine(number + " is an Abundant Number.");
        }
        else
        {
            Console.WriteLine(number + " is Not an Abundant Number.");
        }
    }
}
