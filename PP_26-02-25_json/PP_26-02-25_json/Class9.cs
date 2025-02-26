using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PP_26_02_25_json
{
    class Class9
    {
        public static void Main9()
        {
            //JSON Schema with email validation
            string schemaJson = @"{
            ""type"": ""object"",
            ""properties"": {
                ""email"": { ""type"": ""string"", ""format"": ""email"" }
            },
            ""required"": [""email""]
        }";

            //JSON data
            string validJson = @"{ ""email"": ""test@example.com"" }";
            string invalidJson = @"{ ""email"": ""invalid-email"" }";

            // Validate JSON
            Console.WriteLine("Valid JSON Test:");
            ValidateJson(validJson, schemaJson);

            Console.WriteLine("\nInvalid JSON Test:");
            ValidateJson(invalidJson, schemaJson);
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
                    Console.WriteLine(json+" is valid!");
                }
                else
                {
                    Console.WriteLine(json+" is invalid. Errors:");
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
            catch (JSchemaException ex)
            {
                Console.WriteLine("Error parsing schema: " + ex.Message);
            }
        }
    }
}
