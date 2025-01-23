using System;

class FizzBuzz1
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter a positive: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate that the number is a positive integer
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        int i = 1;

        // Loop from 1 to the entered number using a while loop
        while (i <= number)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Number: " + i);
            }
            i++;
        }
    }
}
