using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ValidateSSN
    {
        static bool IsValidSSN(string ssn)
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            return Regex.IsMatch(ssn, pattern);
        }

        public static void Main15()
        {
            Console.Write("Enter SSN : ");
            string ssn = Console.ReadLine();

            Console.WriteLine(ssn + " -> " + (IsValidSSN(ssn) ? "Valid" : "Invalid"));
        }
    }
}
