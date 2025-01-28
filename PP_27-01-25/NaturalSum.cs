using System;

class NaturalSum
{
    // Method to calculate the sum of n natural numbers
    static int CalculateSum(int n)
    {
        int total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += i;
        }
        return total;
    }

    static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            // Call the method and display the result
            int sum = CalculateSum(n);
            Console.WriteLine("The sum of the first " + n + " natural numbers is: " + sum);
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
