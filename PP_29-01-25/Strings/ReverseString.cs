using System;

class ReverseString
{
    //Method to reverse string
    public static string Reverse(string s)
    {
        string rev = "";
        //loop to reverse string
        for (int i = s.Length - 1; i >= 0; i--)
        {
            rev += s[i];
        }
        return rev;
    }
    //Main Method
    public static void Main(string[] args)
    {
        //Take user input
        Console.WriteLine("Enter a String: ");
        string str = Console.ReadLine();

        //calling Reverse Method
        Console.WriteLine("Reverse String : " + Reverse(str));
    }
}