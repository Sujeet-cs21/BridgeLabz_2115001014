using System;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PP_26_02_25_json
{
    class Class8
    {
        public static void Main8()
        {
            string filePath = "..\\..\\data.json";

            try
            {
                // Read the JSON file
                string jsonContent = File.ReadAllText(filePath);

                // Parse JSON content
                JObject jsonObject = JObject.Parse(jsonContent);

                // Print all keys and values
                PrintJsonKeysAndValues(jsonObject);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: JSON file not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading JSON: " + ex.Message);
            }
        }

        static void PrintJsonKeysAndValues(JObject jsonObject)
        {
            foreach (var property in jsonObject.Properties())
            {
                Console.WriteLine($"Key: {property.Name}, Value: {property.Value}");
            }
        }
    }
}
