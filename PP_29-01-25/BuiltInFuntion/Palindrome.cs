using System;

public class Palindrome
{
    // Method to get input from the user
    public static string GetInput()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    // Method to check if a string is a palindrome
    public static bool IsPalindrome(string str)
    {
        // Remove spaces and convert to lowercase for case-insensitive check
        string cleanStr = str.Replace(" ", "").ToLower(); 

        int left = 0;
        int right = cleanStr.Length - 1;

        while (left < right)
        {
            if (cleanStr[left] != cleanStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    // Method to display the result
    public static void DisplayResult(string str, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine("\"" + str + "\" is a palindrome.");
        }
        else
        {
            Console.WriteLine("\"" + str + "\" is not a palindrome.");
        }
    }

    // main method
    public static void Main(string[] args)
    {
        string inputString = GetInput();
        bool isPalindrome = IsPalindrome(inputString);
        DisplayResult(inputString, isPalindrome);
    }
}