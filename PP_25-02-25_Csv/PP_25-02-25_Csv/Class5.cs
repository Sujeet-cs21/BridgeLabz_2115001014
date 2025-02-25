using System;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Class5
    {
        public static void Main5()
        {
            string filePath = "..\\..\\employees.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            Console.Write("Enter employee name to search: ");
            string searchName = Console.ReadLine()?.Trim();

            bool found = false;

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Read and ignore the header
                    if (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                    }

                    // Search for the employee
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length == 4 && values[1].Trim().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"\nEmployee Found:");
                            Console.WriteLine($"Name: {values[1]}");
                            Console.WriteLine($"Department: {values[2]}");
                            Console.WriteLine($"Salary: {values[3]}");
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}
