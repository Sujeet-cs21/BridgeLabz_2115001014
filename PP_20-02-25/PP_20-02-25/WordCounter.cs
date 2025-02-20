using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace PP_20_02_25
{
    class WordCounter
    {
        static void CountWords(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Error: File not found.");
                    return;
                }

                Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                int totalWords = 0;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line == null) continue;

                        // Extract words using regex
                        string[] words = Regex.Split(line.ToLower(), @"\W+");

                        foreach (string word in words)
                        {
                            if (string.IsNullOrWhiteSpace(word)) continue;
                            totalWords++;

                            if (wordFrequency.ContainsKey(word))
                                wordFrequency[word]++;
                            else
                                wordFrequency[word] = 1;
                        }
                    }
                }

                // Sort words by frequency in descending
                var topWords = wordFrequency.OrderByDescending(w => w.Value).Take(5);

                // Display results
                Console.WriteLine($"\nTotal Words: {totalWords}");
                Console.WriteLine("Top 5 Most Frequent Words:");

                foreach (var word in topWords)
                    Console.WriteLine($"{word.Key}: {word.Value} times");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }

        public static void Main10()
        {
            string filePath = "..\\..\\TextFile1.txt";
            CountWords(filePath);
        }
    }
}
