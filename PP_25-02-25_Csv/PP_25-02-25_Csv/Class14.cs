using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace PP_25_02_25_Csv
{
    class Class14
    {
        public static void Main14()
        {
            string jsonFile = "..\\..\\student.json";
            string csvFile = "..\\..\\student.csv";
            string outputJsonFile = "..\\..\\students_converted.json";

            // Convert JSON to CSV
            JsonToCsv(jsonFile, csvFile);

            // Convert CSV back to JSON
            CsvToJson(csvFile, outputJsonFile);
        }

        static void JsonToCsv(string jsonFile, string csvFile)
        {
            try
            {
                // Read and deserialize JSON file
                string jsonData = File.ReadAllText(jsonFile);
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

                using (StreamWriter writer = new StreamWriter(csvFile))
                {
                    // Write CSV header
                    writer.WriteLine("ID,Name,Age");

                    // Write data rows
                    foreach (var student in students)
                    {
                        writer.WriteLine($"{student.ID},{student.Name},{student.Age}");
                    }
                }

                Console.WriteLine($"JSON successfully converted to CSV: {csvFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting JSON to CSV: {ex.Message}");
            }
        }

        static void CsvToJson(string csvFile, string jsonFile)
        {
            try
            {
                List<Student> students = new List<Student>();

                using (StreamReader reader = new StreamReader(csvFile))
                {
                    string headerLine = reader.ReadLine(); // Read header and discard
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 3)
                        {
                            students.Add(new Student
                            {
                                ID = int.Parse(parts[0]),
                                Name = parts[1],
                                Age = int.Parse(parts[2])
                            });
                        }
                    }
                }

                // Convert list to JSON and save to file
                string jsonOutput = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText(jsonFile, jsonOutput);

                Console.WriteLine($"CSV successfully converted back to JSON: {jsonFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting CSV to JSON: {ex.Message}");
            }
        }
    }
}
