using System;

class MultipleFinder
{
    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The multiples of " + number + " below 100 are:");

        // Loop backward from 100 to 1
        for (int i = 100; i >= 1; i--)
        {
            // Check if i is a multiple of the number
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
