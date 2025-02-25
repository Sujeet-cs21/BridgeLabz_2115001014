using System;
using System.Collections.Generic;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Class12
    {
        public static void Main12()
        {
            string filePath = "..\\..\\student.csv";
            HashSet<string> seenIds = new HashSet<string>(); // Stores unique IDs
            List<string> duplicates = new List<string>(); // Stores duplicate records

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string header = reader.ReadLine(); // Read & store header
                    Console.WriteLine("Checking for duplicate records...");

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length < 1) continue; // Ensure valid line
                        string id = parts[0].Trim(); // Extract ID

                        // Check if ID is already seen
                        if (seenIds.Contains(id))
                        {
                            duplicates.Add(line);
                        }
                        else
                        {
                            seenIds.Add(id);
                        }
                    }
                }

                // Display duplicate records
                if (duplicates.Count > 0)
                {
                    Console.WriteLine("\nDuplicate Records Found:");
                    foreach (var record in duplicates)
                    {
                        Console.WriteLine(record);
                    }
                }
                else
                {
                    Console.WriteLine("\nNo duplicate records found.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: CSV file not found.");
            }
        }
    }
}
