using System;

class CountVovelConsonent
{
    //Method to count vovel
    public static int CountVovel(string s)
    {
        int count = 0;
        //loop to count vovel
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || 
                s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
            {
                count++;
            }
        }
        return count;
    }

    //Method to count Consonent
    public static int CountConsonent(string s)
    {
        int count = 0;
        //loop to count consonent
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u' &&
                s[i] != 'A' && s[i] != 'E' && s[i] != 'I' && s[i] != 'O' && s[i] != 'U')
            {
                count++;
            }
        }
        return count;
    }
    
    //Main Method
    public static void Main(string[] args)
    {
        //Take user input
        Console.WriteLine("Enter a String: ");
        string str=Console.ReadLine();

        //calling CountVovel Method
        Console.WriteLine("Number of vovel : "+CountVovel(str));
        //calling CountConsonent Method
        Console.WriteLine("Number of consonent : "+CountConsonent(str));
    }
}