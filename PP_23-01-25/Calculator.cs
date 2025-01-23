using System;

class Calculator
{
    static void Main(string[] args)
    {

        // Get input values from the user
        Console.Write("Enter the first number: ");
        double first = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the operator (+, -, *, /): ");
        string op = Console.ReadLine();
        
        Console.Write("Enter the second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        // Perform the operation based on the operator
        double result = 0;
        bool validOperation = true;

        // Use switch-case for different operations
        switch(op)
        {
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                // Check if the second number is not zero to avoid division by zero
                if (second != 0)
                {
                    result = first / second;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                validOperation = false;
                break;
        }

        // If the operation was valid, print the result
        if (validOperation)
        {
            Console.WriteLine("The result is: " + result);
        }
    }
}
