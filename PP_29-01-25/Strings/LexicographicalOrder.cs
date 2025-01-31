using System;

class LexicographicalOrder
{
    // Method to compare two strings lexicographically
    public static int CompareStrings(string str1, string str2)
    {
        int minLen = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLen; i++)
        {
            if (str1[i] < str2[i])
            {
                return -1; // str1 comes before str2
            }
            else if (str1[i] > str2[i])
            {
                return 1; // str1 comes after str2
            }
        }

        // If all characters are equal up to the shorter string's length
        // Shorter string comes before longer string
        if (str1.Length < str2.Length)
        {
            return -1; 
        }
        else if (str1.Length > str2.Length)
        {
            return 1;
        }
        else
        {
            return 0; // Strings are equal
        }
    }

    // Main Method
    public static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();
        
        // Calling CompareStrings Method
        int result = CompareStrings(str1, str2);

        if (result < 0)
        {
            Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + "\"");
        }
        else if (result > 0)
        {
            Console.WriteLine("\"" + str1 + "\" comes after \"" + str2 + "\"");
        }
        else
        {
            Console.WriteLine("\"" + str1 + "\" and \"" + str2 + "\" are equal");
        }
    }
}