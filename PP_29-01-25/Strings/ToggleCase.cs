using System;

class ToggleCase
{
    //Method to toggle case
    public static string Toggle(string s)
    {
        string result = "";
        //loop to toggle case
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
            {
                result += (char)(s[i] + 32);
            }
            else if (s[i] >= 'a' && s[i] <= 'z')
            {
                result += (char)(s[i] - 32);
            }
            else
            {
                result += s[i];
            }
        }
        return result;
    }
    //Main Method
    public static void Main(string[] args)
    {
        //Take user input
        Console.WriteLine("Enter a String: ");
        string str = Console.ReadLine();

        //calling Toggle Method
        Console.WriteLine("String after toggling case : " + Toggle(str));
    }
}