using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ValidateIP
    {
        public static bool IsValidIPv4(string ip)
        {
            // Define the regex pattern for a valid IPv4 address
            string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            // Use regex to match the input string
            Regex regex = new Regex(pattern);
            return regex.IsMatch(ip);
        }

        public static void Main10()
        {
            Console.Write("Enter IPv4 : ");
            string IP = Console.ReadLine();

            Console.WriteLine(IP + " -> " + (IsValidIPv4(IP) ? "Valid" : "Invalid"));
        }
    }
}
