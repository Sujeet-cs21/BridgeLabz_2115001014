using System;
using System.Collections.Generic;
using System.Reflection;

namespace PP_24_02_25_Reflection
{
    public class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address}";
        }
    }

    public class ObjectMapper
    {
        // Method to map dictionary values to an object's properties using Reflection
        public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
        {
            T obj = Activator.CreateInstance<T>();

            foreach (var property in properties)
            {
                // Get the property info based on the property name
                PropertyInfo propertyInfo = clazz.GetProperty(property.Key, BindingFlags.Public | BindingFlags.Instance);

                // If the property exists, set its value
                if (propertyInfo != null && propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(obj, Convert.ChangeType(property.Value, propertyInfo.PropertyType));
                }
                else
                {
                    Console.WriteLine($"Property {property.Key} not found or is not writable.");
                }
            }

            return obj;
        }
    }

    class Class8
    {
        public static void Main8()
        {
            // Create a dictionary with property names and values
            var properties = new Dictionary<string, object>
        {
            { "Name", "John" },
            { "Age", 30 },
            { "Address", "1234 2nd Street" }
        };

            // Use the ToObject method to map the dictionary to a Person object
            Person1 person = ObjectMapper.ToObject<Person1>(typeof(Person1), properties);

            // Display the populated object
            Console.WriteLine(person);
        }
    }
}
