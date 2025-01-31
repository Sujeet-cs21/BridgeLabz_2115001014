using System;

public class StringReplace
{
    //Method to replace word
    public static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        // Split the sentence into an array of words
        string[] words = sentence.Split(' ');

        string newSentence = "";

        // Iterate through each word in the array
        for (int i = 0; i < words.Length; i++)
        {
            // Replace the old word with the new word if they match
            if (words[i] == oldWord)
            {
                words[i] = newWord;
            }
            newSentence += words[i] + " "; 
        }

        // Remove the extra space at the end
        newSentence = newSentence.TrimEnd(' ');

        return newSentence;
    }

    public static void Main(string[] args)
    {
        //user input
        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        Console.WriteLine("Enter the new word: ");
        string newWord = Console.ReadLine();

        //calling ReplaceWord Method
        string modifiedSentence = ReplaceWord(sentence, oldWord, newWord);

        Console.WriteLine("Original Sentence: " + sentence);
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }
}