using System;
using System.Reflection;
using System.Text;

namespace PP_24_02_25_Reflection
{
    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public class JsonConverter
    {
        // Method to convert an object to a JSON-like string using Reflection
        public static string ToJson(object obj)
        {
            StringBuilder json = new StringBuilder();
            json.Append("{");

            // Get the type of the object
            Type objType = obj.GetType();

            // Get all public properties of the object
            PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            bool firstProperty = true;

            foreach (var property in properties)
            {
                // Get the property value
                var value = property.GetValue(obj);

                // Start adding a property to the JSON string
                if (!firstProperty)
                {
                    json.Append(", ");
                }

                // Append the property name and value to the JSON string
                json.AppendFormat("\"{0}\": \"{1}\"", property.Name, value);

                firstProperty = false;
            }

            json.Append("}");
            return json.ToString();
        }
    }

    class Class9
    {
        public static void Main9()
        {
            Person2 person = new Person2
            {
                Name = "John",
                Age = 30,
                Address = "1234 2nd Street"
            };

            // Convert the Person object to a JSON-like string
            string jsonRepresentation = JsonConverter.ToJson(person);

            // Display the JSON-like string
            Console.WriteLine(jsonRepresentation);
        }
    }
}
