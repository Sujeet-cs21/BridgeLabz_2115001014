using System;

public class Anagram
{
    // Method to check if two strings are anagrams
    public static bool AreAnagrams(string str1, string str2)
    {
        // If the lengths of the strings are different, they cannot be anagrams
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Create arrays to store character frequencies
        int[] charCounts1 = new int[256];
        int[] charCounts2 = new int[256];

        // Count the occurrences of each character in the strings
        foreach (char c in str1)
        {
            charCounts1[c]++;
        }
        foreach (char c in str2)
        {
            charCounts2[c]++;
        }

        // Compare the character frequencies
        for (int i = 0; i < 256; i++)
        {
            if (charCounts1[i] != charCounts2[i])
            {
                return false;
            }
        }

        return true;
    }

    // Main Method
    public static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        // Calling AreAnagrams Method
        if (AreAnagrams(str1, str2))
        {
            Console.WriteLine("\"" + str1 + "\" and \"" + str2 + "\" are anagrams.");
        }
        else
        {
            Console.WriteLine("\"" + str1 + "\" and \"" + str2 + "\" are not anagrams.");
        }
    }
}