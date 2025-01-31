using System;

public class BasicCalculator
{
    // Method to add two numbers
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method to subtract two numbers
    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    // Method to multiply two numbers
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // Method to divide two numbers
    public static double Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return 0;
        }
        return num1 / num2;
    }

    // main method
    public static void Main(string[] args)
    {
        //input for operation
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        double result;

        // Perform the selected operation
        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                break;
            case 2:
                result = Subtract(num1, num2);
                break;
            case 3:
                result = Multiply(num1, num2);
                break;
            case 4:
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        // Display the result
        Console.WriteLine("Result: " + result);
    }
}