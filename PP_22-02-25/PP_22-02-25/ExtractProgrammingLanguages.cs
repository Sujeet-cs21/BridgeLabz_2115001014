using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ExtractProgrammingLanguages
    {
        static void ExtractLanguages(string text)
        {
            // list of known programming languages
            string[] languages = { "Java", "Python", "JavaScript", "Go", "C#", "Ruby", "PHP", "C++", "Swift", "Kotlin" };

            // Join the languages into a single regex pattern
            //string pattern = @"\b(" + string.Join("|", languages) + @")\b";
            string pattern = @"\b(" + string.Join("|", languages.Select(l => l.Replace("#", @"\#").Replace("+", @"\+"))) + @")\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Main12()
        {
            string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
            ExtractLanguages(text);
        }
    }
}
