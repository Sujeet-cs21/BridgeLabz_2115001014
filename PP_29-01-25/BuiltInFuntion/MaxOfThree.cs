using System;

public class MaxOfThree
{
    // Method to get integer input from the user
    public static int GetIntegerInput(string input)
    {
        Console.Write(input);
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Please enter an integer.");
            Console.Write(input);
        }
        return number;
    }

    // Method to find the maximum of three numbers
    public static int FindMax(int num1, int num2, int num3)
    {
        int max = num1; 
        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }
        return max;
    }

    // main method
    public static void Main(string[] args)
    {
        int num1 = GetIntegerInput("Enter the first number: ");
        int num2 = GetIntegerInput("Enter the second number: ");
        int num3 = GetIntegerInput("Enter the third number: ");

        int maxNumber = FindMax(num1, num2, num3);

        Console.WriteLine("The maximum number is: " + maxNumber);
    }
}