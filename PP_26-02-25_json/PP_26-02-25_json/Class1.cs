using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PP_26_02_25_json
{
    // Student class
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Subjects { get; set; }
    }

    class Class1
    {
        public static void Main1()
        {
            // Creating a Student object
            var student = new Student
            {
                Name = "Student1",
                Age = 20,
                Subjects = new List<string> { "Math", "Science", "English" }
            };

            // Serializing the object to JSON
            string json = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine("Serialized JSON:\n" + json);

            // Deserializing JSON back to object
            var deserializedStudent = JsonConvert.DeserializeObject<Student>(json);
            Console.WriteLine("\nDeserialized Student:");
            Console.WriteLine($"Name: {deserializedStudent.Name}, Age: {deserializedStudent.Age}");
        }
    }

}
