using System;

class Table1
{
    static void Main(string[] args)
    {
        // Get user input for the number
        Console.Write("Enter a number for table from 6 to 9: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Define an array to store the table
        int[] table = new int[4]; // For 6, 7, 8, and 9

        // Calculate the table for 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            table[i - 6] = number * i; // Store the result in the array
        }

        // Display the results
        Console.WriteLine("\n Table:");
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + table[i - 6]);
        }
    }
}
