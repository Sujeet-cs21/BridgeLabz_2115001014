using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PP_26_02_25_json
{
    class Class7
    {
        public static void Main7()
        {
            // JSON data
            string jsonData = @"[
            { ""name"": ""Abc"", ""age"": 30, ""email"": ""abc@example.com"" },
            { ""name"": ""Bcd"", ""age"": 22, ""email"": ""bcd@example.com"" },
            { ""name"": ""Cde"", ""age"": 27, ""email"": ""cde@example.com"" }
        ]";

            // Parse JSON and filter records where age > 25
            List<JObject> filteredRecords = FilterByAge(jsonData, 25);

            // Convert filtered list back to JSON
            string filteredJson = JsonConvert.SerializeObject(filteredRecords, Formatting.Indented);
            Console.WriteLine("Filtered JSON:\n" + filteredJson);
        }

        static List<JObject> FilterByAge(string json, int minAge)
        {
            try
            {
                // Parse JSON array
                JArray jsonArray = JArray.Parse(json);

                // Filter records where age > minAge
                var filteredList = jsonArray
                    .Where(obj => obj.Value<int>("age") > minAge)
                    .Select(obj => (JObject)obj)
                    .ToList();

                return filteredList;
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error parsing JSON: " + ex.Message);
                return new List<JObject>();
            }
        }
    }
}
