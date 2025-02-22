using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class BadWords
    {
        static string CensorBadWords(string text, string[] badWords)
        {
            foreach (var word in badWords)
            {
                string pattern = "\\b" + Regex.Escape(word) + "\\b";
                text = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
            }
            return text;
        }

        public static void Main9()
        {
            string sampleText = "This is a damn bad example with some stupid words.";
            string[] badWords = { "damn", "stupid" };
            string result = CensorBadWords(sampleText, badWords);
            Console.WriteLine(result);
        }
    }
}
