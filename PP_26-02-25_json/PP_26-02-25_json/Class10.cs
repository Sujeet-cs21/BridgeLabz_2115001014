using System;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PP_26_02_25_json
{
    class Class10
    {
        public static void Main10()
        {
            string filePath1 = "..\\..\\file1.json";
            string filePath2 = "..\\..\\file2.json";

            try
            {
                // Read JSON files
                string json1 = File.ReadAllText(filePath1);
                string json2 = File.ReadAllText(filePath2);

                // Parse JSON content
                JObject jsonObject1 = JObject.Parse(json1);
                JObject jsonObject2 = JObject.Parse(json2);

                // Merge JSON objects
                jsonObject1.Merge(jsonObject2, new JsonMergeSettings
                {
                    MergeArrayHandling = MergeArrayHandling.Union
                });

                // Convert merged JSON to string
                string mergedJson = jsonObject1.ToString();

                // Display merged JSON
                Console.WriteLine("Merged JSON:\n" + mergedJson);

                File.WriteAllText("..\\..\\merged.json", mergedJson);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: One of the JSON files is missing. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing JSON: " + ex.Message);
            }
        }
    }
}
