using System;

class FactorFinder
{
    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The factors of " + number + " are:");

        // Loop from 1 to number - 1
        for (int i = 1; i < number; i++)
        {
            // Check if i is a factor of the number
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
