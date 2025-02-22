using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class FindRepeatingWords
    {
        static void FindRepeats(string sentence)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            string pattern = @"\b\w+\b";

            MatchCollection matches = Regex.Matches(sentence, pattern);

            foreach (Match match in matches)
            {
                string word = match.Value.ToLower();
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            foreach (var word in wordCounts)
            {
                if (word.Value > 1)
                {
                    Console.WriteLine(word.Key);
                }
            }
        }

        public static void Main14()
        {
            string sentence = "This is is a repeated repeated word test.";
            FindRepeats(sentence);
        }
    }
}
