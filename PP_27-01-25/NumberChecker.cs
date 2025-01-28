using System;

public class NumberChecker
{
    // Method to check whether the number is positive or negative
    public string IsPositive(int number)
    {
        if (number >= 0)
        {
            return "positive";
        }
        else
        {
            return "negative";
        }
    }

    // Method to check whether the number is even or odd
    public string IsEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            return "even";
        }
        else
        {
            return "odd";
        }
    }

    // Method to compare two numbers
    public int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            return 1;  // number1 is greater
        }
        else if (number1 < number2)
        {
            return -1; // number1 is less
        }
        else
        {
            return 0;  // both numbers are equal
        }
    }

    static void Main(string[] args)
    {
        // Create an instance of NumberChecker class
        NumberChecker checker = new NumberChecker();

        // Array to store 5 numbers
        int[] numbers = new int[5];

        // Take user input for 5 numbers
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Loop through the array and check each number
        for (int i = 0; i < numbers.Length; i++)
        {
            string sign = checker.IsPositive(numbers[i]);
            Console.Write("Number " + (i + 1) + " is " + sign);

            if (sign == "positive")
            {
                string evenOrOdd = checker.IsEvenOrOdd(numbers[i]);
                Console.WriteLine(" and it is " + evenOrOdd + ".");
            }
            else
            {
                Console.WriteLine(" and it is negative.");
            }
        }

        // Compare the first and last element of the array
        int comparisonResult = checker.Compare(numbers[0], numbers[4]);

        if (comparisonResult == 1)
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else if (comparisonResult == -1)
        {
            Console.WriteLine("The first number is less than the last number.");
        }
        else
        {
            Console.WriteLine("The first number is equal to the last number.");
        }
    }
}
