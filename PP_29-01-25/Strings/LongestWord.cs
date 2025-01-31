using System;

class LongestWord
{
    //Method to find longest word
    static string FindLongestWord(string sentence)
    {
        //splitting sentence into words
        string[] words = sentence.Split(' ');
        string longestWord = "";
        
        //loop to find longest word
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
        }
        return longestWord;
    }

    //Main Method
    static void Main(string[] args)
    {
        //Take user input
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        //calling FindLongestWord Method
        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("Longest word: " + longestWord);
    }
}
