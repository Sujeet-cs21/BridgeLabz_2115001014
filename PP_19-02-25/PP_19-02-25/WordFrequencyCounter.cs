using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace PP_19_02_25
{
    class WordFrequencyCounter
    {
        public static void CountWordFrequency(string filePath)
        {
            try
            {
                // Read the entire text from the file
                string text = File.ReadAllText(filePath);

                // Convert the text to lowercase and remove non-alphabetic characters
                string[] words = Regex.Split(text.ToLower(), @"\W+");

                // Create a dictionary to hold the word counts
                Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

                // Count the frequency of each word
                foreach (var word in words)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        if (wordFrequency.ContainsKey(word))
                        {
                            wordFrequency[word]++;
                        }
                        else
                        {
                            wordFrequency[word] = 1;
                        }
                    }
                }

                // Print the word frequencies
                foreach (var word in wordFrequency)
                {
                    Console.WriteLine($"\"{word.Key}\": {word.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void Main14()
        {
            // Path to the text file
            string filePath = "..\\..\\Program.cs";

            // Call the function
            CountWordFrequency(filePath);
        }
    }

}
