using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class CapitalWordExtraction
    {
        static void ExtractCapitalizedWords(string text)
        {
            string pattern = "\\b[A-Z][a-z]*\\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + ", ");
            }
        }

        public static void Main5()
        {
            string sampleText = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            ExtractCapitalizedWords(sampleText);
        }
    }
}
