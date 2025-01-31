using System;

public class RemoveDuplicates
{
    // Method to remove duplicate characters from a string
    public static string RemoveDuplicateChars(string str)
    {
        bool[] charSet = new bool[256];
        string result = "";

        // Iterate through each character in the string
        foreach (char c in str)
        {
            // If the character is not encountered before
            if (!charSet[c])
            {
                result += c;
                charSet[c] = true; // Mark the character as encountered
            }
        }

        return result;
    }

    // Main Method
    public static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();
        
        // Calling RemoveDuplicateChars Method
        string modifiedString = RemoveDuplicateChars(str);
        Console.WriteLine("Modified String: " + modifiedString);
    }
}