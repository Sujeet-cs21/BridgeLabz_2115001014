using System;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PP_26_02_25_json
{
    class Class3
    {
        public static void Main3()
        {
            string filePath = "..\\..\\data.json"; // JSON file path

            try
            {
                // Read JSON file
                string jsonContent = File.ReadAllText(filePath);

                // Parse JSON content
                JObject jsonObject = JObject.Parse(jsonContent);

                // Extract specific fields
                string name = jsonObject.Value<string>("name");
                string email = jsonObject.Value<string>("email");

                // Display extracted values
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Email: {email}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: JSON file not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
