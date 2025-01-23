using System;

class OddEven
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate input
        if (number <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        Console.WriteLine("Odd and Even numbers from 1 to " + number + ":");

        // Iterate from 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is an Even number");
            }
            else
            {
                Console.WriteLine(i + " is an Odd number");
            }
        }
    }
}
