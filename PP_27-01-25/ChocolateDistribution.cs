using System;

class ChocolateDistribution
{
    // Method to find the quotient and remainder
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;    // Chocolates per child
        int remainder = number % divisor;  // Remaining chocolates
        return new int[] { quotient, remainder };
    }

    static void Main(string[] args)
    {
        // Get the number of chocolates from the user
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        // Get the number of children from the user
        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Check if there are children to divide the chocolates
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Cannot divide chocolates among zero children.");
        }
        else
        {
            // Calling FindRemainderAndQuotient method
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            // Display the results
            Console.WriteLine("Each child will get " + result[0] + " chocolates.");
            Console.WriteLine("Remaining chocolates: " + result[1]);
        }
    }
}
