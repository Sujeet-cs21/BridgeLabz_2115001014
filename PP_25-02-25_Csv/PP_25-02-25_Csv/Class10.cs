using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PP_25_02_25_Csv
{
    class Class10
    {
        public static void Main10()
        {
            string file1 = "..\\..\\students1.csv"; // File with ID, Name, Age
            string file2 = "..\\..\\students2.csv"; // File with ID, Marks, Grade
            string outputFile = "..\\..\\merged_students.csv"; // Merged output file

            // Read the first CSV into a dictionary
            Dictionary<string, (string Name, string Age)> students1 = File.ReadAllLines(file1)
                .Skip(1) // Skip header
                .Select(line => line.Split(','))
                .ToDictionary(parts => parts[0], parts => (parts[1], parts[2]));

            // Read the second CSV into a dictionary
            Dictionary<string, (string Marks, string Grade)> students2 = File.ReadAllLines(file2)
                .Skip(1)
                .Select(line => line.Split(','))
                .ToDictionary(parts => parts[0], parts => (parts[1], parts[2]));

            // Merge data
            List<string> mergedData = new List<string> { "ID,Name,Age,Marks,Grade" }; // Header
            foreach (var id in students1.Keys)
            {
                if (students2.ContainsKey(id))
                {
                    var (name, age) = students1[id];
                    var (marks, grade) = students2[id];
                    mergedData.Add($"{id},{name},{age},{marks},{grade}");
                }
            }

            // Write to new CSV file
            File.WriteAllLines(outputFile, mergedData);

            Console.WriteLine("CSV files merged successfully into 'merged_students.csv'.");
        }
    }
}
