using System;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Class4
    {
        public static void Main4()
        {
            string filePath = "..\\..\\student.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    Console.WriteLine("Students who scored more than 80 marks:");
                    Console.WriteLine("ID\tName\t\tAge\tMarks");
                    Console.WriteLine("---------------------------------");

                    // Read and ignore the header
                    if (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                    }

                    // Read and filter records
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length == 4 && int.TryParse(values[3], out int marks) && marks > 80)
                        {
                            Console.WriteLine($"{values[0]}\t{values[1],-10}\t{values[2]}\t{values[3]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}
