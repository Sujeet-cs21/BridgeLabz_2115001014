using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PP_25_02_25_Csv
{
    class Class7
    {
        public static void Main7()
        {
            string filePath = "..\\..\\employees.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            List<(string ID, string Name, string Department, decimal Salary)> employees = new List<(string, string, string, decimal)>();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Read and ignore the header
                    if (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                    }

                    // Read records and store in a list
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length == 4 && decimal.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal salary))
                        {
                            employees.Add((values[0], values[1], values[2], salary));
                        }
                    }
                }

                // Sort employees by Salary in descending order
                var topEmployees = employees.OrderByDescending(e => e.Salary).Take(5);

                // Print top 5 highest-paid employees
                Console.WriteLine("Top 5 Highest-Paid Employees:");
                Console.WriteLine("ID\tName\t\tDepartment\tSalary");
                Console.WriteLine("-----------------------------------------");

                foreach (var emp in topEmployees)
                {
                    Console.WriteLine($"{emp.ID}\t{emp.Name,-10}\t{emp.Department,-10}\t{emp.Salary:C}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}
