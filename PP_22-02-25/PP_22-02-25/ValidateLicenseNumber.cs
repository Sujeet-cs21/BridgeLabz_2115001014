using System;
using System.Text.RegularExpressions;

namespace PP_22_02_25
{
    class ValidateLicenseNumber
    {
        static bool IsValidLicensePlate(string plate)
        {
            string pattern = "^[A-Z]{2}\\d{4}$";
            return Regex.IsMatch(plate, pattern);
        }

        public static void Main2()
        {
            Console.Write("Enter License Plate Number : ");
            string plate = Console.ReadLine();

            Console.WriteLine(plate + " -> " + (IsValidLicensePlate(plate) ? "Valid" : "Invalid"));
        }
    }
}
