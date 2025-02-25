using System;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Class1
    {
        public static void Main1()
        {
            string filePath = "..\\..\\student.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            using (var reader = new StreamReader(filePath))
            {
                Console.WriteLine("ID\tName\t\tAge\tMarks");
                Console.WriteLine("---------------------------------");

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length == 4)
                    {
                        Console.WriteLine($"{values[0]}\t{values[1],-10}\t{values[2]}\t{values[3]}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid record found.");
                    }
                }
            }
        }
    }
}
