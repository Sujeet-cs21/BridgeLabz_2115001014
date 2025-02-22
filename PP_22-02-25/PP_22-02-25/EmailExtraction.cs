using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class EmailExtraction
    {
        static void ExtractEmails(string text)
        {
            string pattern = "[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Main4()
        {
            string sampleText = "Contact us at support@example.com and info@company.org";
            ExtractEmails(sampleText);
        }
    }
}
