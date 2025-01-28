using System;

class SmallestAndLargestFinder
{
    // Method to find the smallest and largest of three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = number1;
        int largest = number1;

        // Check for the smallest number
        if (number2 < smallest) smallest = number2;
        if (number3 < smallest) smallest = number3;

        // Check for the largest number
        if (number2 > largest) largest = number2;
        if (number3 > largest) largest = number3;

        return new int[] { smallest, largest };
    }

    static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        // Call the method and get the result
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Display the smallest and largest numbers
        Console.WriteLine("Smallest number: " + result[0]);
        Console.WriteLine("Largest number: " + result[1]);
    }
}
