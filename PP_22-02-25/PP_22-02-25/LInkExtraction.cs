using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class LInkExtraction
    {
        static void ExtractLinks(string text)
        {
            string pattern = "https?://[a-zA-Z0-9./-]+";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Main7()
        {
            string sampleText = "Visit https://www.google.com and http://example.org for more info.";
            ExtractLinks(sampleText);
        }
    }
}
