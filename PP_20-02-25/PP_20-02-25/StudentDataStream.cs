using System.IO;
using System;

namespace PP_20_02_25
{
    class StudentDataStream
    {
        static string filePath = "..\\..\\students.dat"; // Binary file to store data

        // Method to store student details using BinaryWriter
        static void StoreStudentData()
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(1);
                    writer.Write("Student1");
                    writer.Write(3.8);

                    writer.Write(2);
                    writer.Write("Student2");
                    writer.Write(3.5);

                    writer.Write(3);
                    writer.Write("Student3");
                    writer.Write(3.9);

                    Console.WriteLine("Student data written successfully.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        // Method to retrieve student details using BinaryReader
        static void RetrieveStudentData()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No data file found.");
                    return;
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    Console.WriteLine("Retrieved Student Data:\n");

                    while (fs.Position < fs.Length)
                    {
                        int rollNo = reader.ReadInt32();
                        string name = reader.ReadString();
                        double gpa = reader.ReadDouble();

                        Console.WriteLine($"Roll No: {rollNo}, Name: {name}, GPA: {gpa}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
        }

        public static void Main7()
        {
            // Store data
            StoreStudentData();

            // Retrieve and display data
            RetrieveStudentData();
        }
    }
}
