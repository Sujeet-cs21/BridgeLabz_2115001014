using System;

class SubStringGenerator
{
    //Method for generating substring
    static string GetSubstring(string str, int start, int end)
    {
        string result = "";
        for (int i = start; i < end; i++)
        {
            result += str[i];
        }
        return result;
    }

    //Main method
    static void Main()
    {
        // Taking user input
        Console.Write("Enter a string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter start index: ");
        int startIndex = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end index: ");
        int endIndex = Convert.ToInt32(Console.ReadLine());

        // Generating substring
        string getSubstring = GetSubstring(s1, startIndex, endIndex);
        
        // Generating substring using built-in Substring method
        string builtInSubstring = s1.Substring(startIndex, endIndex - startIndex);
        
        // Output results
        Console.WriteLine("Substring : " + getSubstring);
        Console.WriteLine("Substring using Substring method: " + builtInSubstring);
    }
}
