using System;

class NumberChecker
{
    //Method to count digits in the number
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

    //Method to store the digits in a digits array
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

    //Method to reverse digit array
    public static int[] ReverseDigitsArray(int[] digits)
    {
        int[] reversedDigits = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversedDigits[i] = digits[digits.Length - 1 - i];
        }
        return reversedDigits;
    }

    //Method to compare the original and reversed array
    public static bool IsEqualArray(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[] reversedDigits = ReverseDigitsArray(digits);
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] != reversedDigits[i])
            {
                return false;
            }
        }
        return true;
    }

    //Method to check if a number is a palindrome
    public static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }
        return originalNumber == reversedNumber;
    }

    //Method to check if a number is a Duck number using Array
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
    //main method
    static void Main(string[] args)
    {
        //input for the number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        //count of digits
        int count = CountDigits(number);
        Console.WriteLine("Count of digits: " + count);

        //digits array
        int[] digits = GetDigitsArray(number);
        Console.Write("Digits: ");
        foreach (int digit in digits)
        {
            Console.Write(digit + " ");
        }
        Console.WriteLine();

        //reverse digits array
        int[] reversedDigits = ReverseDigitsArray(digits);
        Console.Write("Reversed Digits: ");
        foreach (int digit in reversedDigits)
        {
            Console.Write(digit + " ");
        }
        Console.WriteLine();

        //check if the original and reversed array are equal
        bool isEqual = IsEqualArray(number);
        Console.WriteLine("Is Equal Array: " + isEqual);

        //check if it's a palindrome
        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine("Is Palindrome: " + isPalindrome);

        //check if it's a duck number
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuck);
    }
}