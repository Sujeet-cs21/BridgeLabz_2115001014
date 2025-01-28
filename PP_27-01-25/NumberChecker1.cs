using System;

public class NumberChecker1
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        int count = 0;
        number = Math.Abs(number);
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // Method to store the digits of the number in a digits array
    public static int[] GetDigitsArray(int number)
    {
        number = Math.Abs(number);
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        foreach (int digit in digits)
        {
            if (digit == 0)
            {
                return true;
            }
        }
        return false;
    }

    // Method to check if a number is an Armstrong number
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int numDigits = digits.Length;
        int sum = 0;
        foreach (int digit in digits)
        {
            int power = 1;
            for (int i = 0; i < numDigits; i++)
            {
                power *= digit;
            }
            sum += power;
        }
        return sum == number;
    }

    // Method to find the largest and second largest elements
    public static int[] FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }

        return new int[] { largest, secondLargest };
    }

    // Method to find the smallest and second smallest elements
    public static int[] FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }

        return new int[] { smallest, secondSmallest };
    }

    // Main method
    public static void Main(string[] args)
    {
        // Input number
		Console.WriteLine("Enter a number:");
		int number = Convert.ToInt32(Console.ReadLine());

        // Count of digits
        int count = CountDigits(number);
        Console.WriteLine("Count of digits: " + count);

        // Digits array
        int[] digits = GetDigitsArray(number);
        Console.Write("Digits: ");
        foreach (int digit in digits)
        {
            Console.Write(digit + " ");
        }
        Console.WriteLine();

        // Check if it's a duck number
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuck);

        // Check if it's an Armstrong number
        bool isArmstrong = IsArmstrongNumber(number);
        Console.WriteLine("Is Armstrong Number: " + isArmstrong);

        // Largest and second largest digits
        int[] largestTwo = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest digit: " + largestTwo[0]);
        Console.WriteLine("Second largest digit: " + largestTwo[1]);

        // Smallest and second smallest digits
        int[] smallestTwo = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest digit: " + smallestTwo[0]);
        Console.WriteLine("Second smallest digit: " + smallestTwo[1]);
    }
}