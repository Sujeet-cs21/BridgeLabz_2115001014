using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PP_26_02_25_json
{
    class Class4
    {
        public static void Main4()
        {
            // JSON strings representing two objects
            string json1 = @"{ ""name"": ""Abc"", ""email"": ""abc@example.com"" }";
            string json2 = @"{ ""age"": 25, ""city"": ""New Delhi"" }";

            // Parse JSON strings into JObject
            JObject jsonObject1 = JObject.Parse(json1);
            JObject jsonObject2 = JObject.Parse(json2);

            // Merge jsonObject2 into jsonObject1
            jsonObject1.Merge(jsonObject2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union
            });

            // Convert merged JSON object to string
            string mergedJson = jsonObject1.ToString(Formatting.Indented);

            // Display merged JSON
            Console.WriteLine("Merged JSON:\n" + mergedJson);
        }
    }
}
