using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace PP_26_02_25_json
{
    class Class12
    {
        public static void Main12()
        {
            string csvFilePath = "..\\..\\students1.csv";

            try
            {
                // Read CSV and convert to JSON
                string jsonResult = ConvertCsvToJson(csvFilePath);

                // Print JSON output
                Console.WriteLine("Converted JSON:\n" + jsonResult);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: CSV file not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing CSV: " + ex.Message);
            }
        }

        static string ConvertCsvToJson(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                // Read CSV into a list of dynamic objects
                var records = csv.GetRecords<dynamic>();

                // Convert to JSON
                return JsonConvert.SerializeObject(records, Formatting.Indented);
            }
        }
    }
}
