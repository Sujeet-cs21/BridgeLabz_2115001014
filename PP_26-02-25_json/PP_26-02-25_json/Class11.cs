using System;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace PP_26_02_25_json
{
    class Class11
    {
        public static void Main11()
        {
            string json = @"{
            ""Person"": {
                ""Name"": ""Abc"",
                ""Age"": 30,
                ""Email"": ""abc@example.com""
            }
        }";

            try
            {
                // Convert JSON to XML
                XNode xmlNode = JsonConvert.DeserializeXNode(json, "Root");

                // Print XML output
                Console.WriteLine("Converted XML:\n" + xmlNode.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error converting JSON to XML: " + ex.Message);
            }
        }
    }
}
