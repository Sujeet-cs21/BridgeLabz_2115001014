using System;
using System.Collections.Generic;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Marks { get; set; }

        public override string ToString()
        {
            return $"Student {{ ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks} }}";
        }
    }


    class Class9
    {
        public static void Main9()
        {
            string filePath = "..\\..\\student.csv";
            List<Student> studentList = new List<Student>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    reader.ReadLine(); // Skip header row

                    while ((line = reader.ReadLine()) != null)
                    {
                        var values = line.Split(',');

                        if (values.Length == 4 &&
                            int.TryParse(values[0].Trim(), out int id) &&
                            int.TryParse(values[2].Trim(), out int age) &&
                            double.TryParse(values[3].Trim(), out double marks))
                        {
                            Student student = new Student
                            {
                                ID = id,
                                Name = values[1].Trim(),
                                Age = age,
                                Marks = marks
                            };

                            studentList.Add(student);
                        }
                    }
                }

                // Print all Student objects
                Console.WriteLine("Students List:");
                foreach (var student in studentList)
                {
                    Console.WriteLine(student);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}
