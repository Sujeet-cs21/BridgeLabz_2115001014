using System;
using System.Reflection;

namespace PP_24_02_25_Reflection
{
    class Configuration
    {
        private static string API_KEY = "original-api-key";

        public static void DisplayAPIKey()
        {
            Console.WriteLine($"API_KEY: {API_KEY}");
        }
    }

    class Class7
    {
        public static void Main7()
        {
            // Display the original value of API_KEY
            Console.WriteLine("Before using Reflection:");
            Configuration.DisplayAPIKey();

            // Using Reflection to access the private static field 'API_KEY'
            Type configType = typeof(Configuration);
            FieldInfo apiKeyField = configType.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            // Check if the field exists
            if (apiKeyField != null)
            {
                // Modify the static field value
                apiKeyField.SetValue(null, "new-api-key");

                // Display the updated value of API_KEY
                Console.WriteLine("\nAfter using Reflection to modify API_KEY:");
                Configuration.DisplayAPIKey();
            }
            else
            {
                Console.WriteLine("API_KEY field not found.");
            }
        }
    }
}
