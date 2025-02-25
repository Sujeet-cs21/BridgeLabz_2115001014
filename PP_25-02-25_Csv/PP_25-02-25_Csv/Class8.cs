using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace PP_25_02_25_Csv
{
    class Class8
    {
        public static void Main8()
        {
            string filePath = "..\\..\\employees1.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Regex for valid email
            string phonePattern = @"^\d{10}$"; // Regex for 10-digit phone number

            List<string> invalidRows = new List<string>();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Read header
                    string header = reader.ReadLine();
                    Console.WriteLine("Validating CSV data...\n");

                    // Read and validate each row
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length < 5) //columns: ID, Name, Department, Email, Phone
                        {
                            invalidRows.Add($"Invalid format: {line}");
                            continue;
                        }

                        string email = values[3].Trim();
                        string phone = values[4].Trim();

                        bool isValidEmail = Regex.IsMatch(email, emailPattern);
                        bool isValidPhone = Regex.IsMatch(phone, phonePattern);

                        if (!isValidEmail || !isValidPhone)
                        {
                            string error = $"Error in row: {line} - ";
                            if (!isValidEmail) error += "Invalid Email. ";
                            if (!isValidPhone) error += "Invalid Phone Number.";
                            invalidRows.Add(error);
                        }
                    }
                }

                // Print validation results
                if (invalidRows.Count > 0)
                {
                    Console.WriteLine("Invalid Rows Found:");
                    foreach (var row in invalidRows)
                    {
                        Console.WriteLine(row);
                    }
                }
                else
                {
                    Console.WriteLine("All records are valid.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}
