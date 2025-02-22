using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ValidateUserName
    {
        static bool IsValidUsername(string username)
        {
            string pattern = "^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
            return Regex.IsMatch(username, pattern);
        }

        public static void Main1()
        {
            Console.Write("Enter UserName : ");
            string username = Console.ReadLine();
            Console.WriteLine(username + " -> " + (IsValidUsername(username) ? "Valid" : "Invalid"));
            
        }
    }
}
