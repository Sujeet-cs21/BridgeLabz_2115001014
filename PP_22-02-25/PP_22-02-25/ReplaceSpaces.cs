using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ReplaceSpaces
    {
        static string ReplaceMultipleSpaces(string text)
        {
            return Regex.Replace(text, "\\s+", " ");
        }

        public static void Main8()
        {
            string sampleText = "This    is  an   example   with  multiple   spaces.";
            string result = ReplaceMultipleSpaces(sampleText);
            Console.WriteLine(result);
        }
    }
}
