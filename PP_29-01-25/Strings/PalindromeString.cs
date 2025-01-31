using System;

class PalindromeString
{
    //Method to check palindrome
    public static bool IsPalindrome(string s)
    {
        //loop to check palindrome
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
    //Main Method
    public static void Main(string[] args)
    {
        //Take user input
        Console.WriteLine("Enter a String: ");
        string str = Console.ReadLine();

        //calling IsPalindrome Method
        if (IsPalindrome(str))
        {
            Console.WriteLine("String is Palindrome");
        }
        else
        {
            Console.WriteLine("String is not Palindrome");
        }
    }
}