using System;

class QuotientAndRemainder
{
    // Method to find the remainder and quotient of a number
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;    // Calculate quotient
        int remainder = number % divisor;  // Calculate remainder
        return new int[] { quotient, remainder };
    }

    static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter the dividend : ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        // Check for division by zero
        if (divisor == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        else
        {
            // Calling FindRemainderAndQuotient method 
            int[] result = FindRemainderAndQuotient(number, divisor);

            // Display the quotient and remainder
            Console.WriteLine("Quotient: " + result[0]);
            Console.WriteLine("Remainder: " + result[1]);
        }
    }
}
