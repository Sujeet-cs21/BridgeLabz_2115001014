using System;

public class RemoveCharacter
{
    //Method to remove character
    public static string RemoveChar(string str, char c)
    {
        string result = "";
        foreach (char ch in str)
        {
            if (ch != c)
            {
                result += ch;
            }
        }
        return result;
    }

    //Main Method
    public static void Main(string[] args)
    {
        //Take user input
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();

        //calling RemoveChar Method
        string modifiedString = RemoveChar(str, c);
        Console.WriteLine("Modified String: " + modifiedString);
    }
}