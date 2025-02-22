using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ValidateCreditCard
    {
        static bool IsValidCreditCard(string cardNumber)
        {
            string pattern = "^(4\\d{15}|5\\d{15})$";

            return Regex.IsMatch(cardNumber, pattern);
        }

        public static void Main11()
        {
            Console.Write("Enter Credit Card Number: ");
            string cardNumber = Console.ReadLine();

            Console.WriteLine(cardNumber + " -> " + (IsValidCreditCard(cardNumber) ? "Valid" : "Invalid"));
        }
    }
}
