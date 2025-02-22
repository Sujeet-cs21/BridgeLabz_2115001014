using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ExtractCurrencyValues
    {
        static void ExtractValues(string text)
        {
            string pattern = @"(\$?\d+(\.\d{1,2})?)";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }

        public static void Main13()
        {
            string text = "The price is $45.99, and the discount is $ 10.50.";

            ExtractValues(text);
        }
    }
}
