using System;

class Table
{
    static void Main(string[] args)
    {
        // Taking input from the user
        Console.Write("Enter a number for table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Define an array to store the multiplication results
        int[] table = new int[10];

        // Calculate and store results in the array
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = number * (i + 1);
        }

        // Display the multiplication table
        Console.WriteLine("\nMultiplication Table for " + number + ":");
        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine(number + " * " + (i + 1) + " = " + table[i]);
        }
    }
}
