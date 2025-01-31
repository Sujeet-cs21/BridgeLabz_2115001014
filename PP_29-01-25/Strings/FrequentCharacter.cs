using System;

public class FrequentCharacter
{
    // Method to find the most frequent character in a string
    public static char FindMostFrequent(string str)
    {
        // Create an array to store character frequencies
        int[] charCounts = new int[256];

        // Count the occurrences of each character
        foreach (char c in str)
        {
            charCounts[c]++;
        }

        // Find the character with the highest frequency
        char mostFrequent = str[0]; 
        int maxCount = 0;
        for (int i = 0; i < 256; i++)
        {
            if (charCounts[i] > maxCount)
            {
                mostFrequent = (char)i;
                maxCount = charCounts[i];
            }
        }

        return mostFrequent;
    }

    // Main Method
    public static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();

        //calling FindMostFrequent Method
        char mostFrequentChar = FindMostFrequent(str);
        Console.WriteLine("Most Frequent Character: " + mostFrequentChar);
    }
}