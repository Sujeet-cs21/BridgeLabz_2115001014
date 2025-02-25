using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Class6
    {
        public static void Main6()
        {
            string inputFilePath = "..\\..\\employees.csv";  // Input CSV file
            string outputFilePath = "..\\..\\updated_employees.csv";  // Output CSV file

            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            List<string> updatedLines = new List<string>();

            try
            {
                using (var reader = new StreamReader(inputFilePath))
                {
                    // Read the header and add it to the updated list
                    if (!reader.EndOfStream)
                    {
                        string header = reader.ReadLine();
                        updatedLines.Add(header);
                    }

                    // Read and update records
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length == 4 && values[2].Trim().Equals("IT", StringComparison.OrdinalIgnoreCase))
                        {
                            if (decimal.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal salary))
                            {
                                salary *= 1.10m; // Increase salary by 10%
                                values[3] = salary.ToString("F2", CultureInfo.InvariantCulture);
                            }
                        }

                        updatedLines.Add(string.Join(",", values));
                    }
                }

                // Write updated data to a new CSV file
                File.WriteAllLines(outputFilePath, updatedLines);
                Console.WriteLine($"Updated CSV file saved as '{outputFilePath}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing file: {ex.Message}");
            }
        }
    }
}
