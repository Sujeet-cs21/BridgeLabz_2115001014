using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class DateExtraction
    {
        static void ExtractDates(string text)
        {
            string pattern = "\\b\\d{2}/\\d{2}/\\d{4}\\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Main6()
        {
            string sampleText = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
            ExtractDates(sampleText);
        }
    }
}
