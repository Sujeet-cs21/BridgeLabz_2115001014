using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

namespace PP_24_02_25_Annotations
{
    //JsonField attribute
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class JsonFieldAttribute : Attribute
    {
        public string Name { get; }

        public JsonFieldAttribute(string name)
        {
            Name = name;
        }
    }

    //Creating the User class and apply the JsonField attribute
    class User2
    {
        [JsonField("user_name")]
        public string Username { get; set; }

        [JsonField("user_email")]
        public string Email { get; set; }

        public int Age { get; set; }

        public User2(string username, string email, int age)
        {
            Username = username;
            Email = email;
            Age = age;
        }
    }

    //Implementing a method to serialize an object using JsonField attributes
    class JsonSerializerCustom
    {
        public static string SerializeToJson(object obj)
        {
            Type type = obj.GetType();
            Dictionary<string, object> jsonDict = new Dictionary<string, object>();

            foreach (PropertyInfo prop in type.GetProperties())
            {
                var attribute = (JsonFieldAttribute)Attribute.GetCustomAttribute(prop, typeof(JsonFieldAttribute));

                string jsonKey = attribute?.Name ?? prop.Name; // Use attribute name if present, else use property name
                object value = prop.GetValue(obj);

                jsonDict[jsonKey] = value;
            }

            return JsonSerializer.Serialize(jsonDict, new JsonSerializerOptions { WriteIndented = true });
        }
    }

    //Test serialization
    class Class11
    {
        public static void Main11()
        {
            User2 user = new User2("User", "User@example.com", 30);
            string json = JsonSerializerCustom.SerializeToJson(user);
            Console.WriteLine(json);
        }
    }
}
