using System;

class PowerCalculator
{
    static void Main(string[] args)
    {
        // Taking user input for number and power
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        // Initialize result variable to 1
        int result = 1;

        // Loop from 1 to power
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        // Display the result
        Console.WriteLine(number+" raised to the power of "+power+" is "+result);
    }
}
