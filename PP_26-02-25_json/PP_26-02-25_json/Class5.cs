using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace PP_26_02_25_json
{
    class Class5
    {
        public static void Main5()
        {
            // Define JSON schema
            string schemaJson = @"{
            ""type"": ""object"",
            ""properties"": {
                ""name"": { ""type"": ""string"" },
                ""email"": { ""type"": ""string"", ""format"": ""email"" },
                ""age"": { ""type"": ""integer"", ""minimum"": 18 }
            },
            ""required"": [""name"", ""email""]
        }";

            //JSON data
            string jsonData = @"{
            ""name"": ""Abc"",
            ""email"": ""abc@example.com"",
            ""age"": 25
        }";

            // Validate JSON
            ValidateJson(jsonData, schemaJson);
        }

        static void ValidateJson(string json, string schemaJson)
        {
            try
            {
                // Parse schema and JSON object
                JSchema schema = JSchema.Parse(schemaJson);
                JObject jsonObject = JObject.Parse(json);

                // Validate JSON against schema
                IList<string> validationErrors = new List<string>();
                bool isValid = jsonObject.IsValid(schema, out validationErrors);

                // Display validation result
                if (isValid)
                {
                    Console.WriteLine("JSON is valid!");
                }
                else
                {
                    Console.WriteLine("JSON is invalid. Errors:");
                    foreach (var error in validationErrors)
                    {
                        Console.WriteLine("- " + error);
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error parsing JSON: " + ex.Message);
            }
        }
    }
}
