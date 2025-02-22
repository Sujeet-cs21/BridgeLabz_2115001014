using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ValidateHexColorCode
    {
        static bool IsValidHexColor(string color)
        {
            string pattern = "^#[0-9A-Fa-f]{6}$";
            return Regex.IsMatch(color, pattern);
        }

        public static void Main3()
        {
            Console.Write("Enter Hex Color Code : ");
            string color = Console.ReadLine();

            Console.WriteLine(color + " -> " + (IsValidHexColor(color) ? "Valid" : "Invalid"));
        }
    }
}
