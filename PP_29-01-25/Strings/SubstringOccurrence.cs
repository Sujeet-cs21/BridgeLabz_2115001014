using System;

class SubstringOccurrence
{
    //Method to count occurrences of substring
    static int CountSubstringOccurrences(string str, string substr)
    {
        
        int count = 0;
        //loop to count occurrences of substring
        for (int i = 0; i <= str.Length - substr.Length; i++)
        {
            //loop to check substring
            int j;
            for (j = 0; j < substr.Length; j++)
            {
                //if substring not found
                if (str[i + j] != substr[j])
                {
                    break;
                }
            }
            //if substring found
            if (substr.Length == j)
                count++;
        }
        return count;
    }

    //Main Method
    static void Main(string[] args)
    {
        //Take user input
        Console.Write("Enter the main string: ");
        string str = Console.ReadLine();
        Console.Write("Enter the substring: ");
        string substr = Console.ReadLine();

        //calling CountSubstringOccurrences Method
        int occurrences = CountSubstringOccurrences(str, substr);
        Console.WriteLine("Occurrences of substring: " + occurrences);
    }
}
