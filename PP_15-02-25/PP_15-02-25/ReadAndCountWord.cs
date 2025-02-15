using System;
using System.IO;

namespace PP_15_02_25
{
    class ReadAndCountWord
    {
        public static void Main6()
        {
            string filePath = "..\\..\\SearchWord.cs";
            string wordToFind = "str";
            int wordCount = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into words
                        string[] words = line.Split(new char[] { ' ', '\t', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (word.Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
                            {
                                wordCount++;
                            }
                        }
                    }
                }

                Console.WriteLine($"'{wordToFind}' appears {wordCount} times");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
