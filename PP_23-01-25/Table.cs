using System;

class Table
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter the number for the table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Loop through numbers 6 to 9 and calculate the table
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
