using System.IO;
using System;

namespace PP_25_02_25_Csv
{
    class Class3
    {
        public static void Main3()
        {
            string filePath = "..\\..\\employees.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            try
            {
                int recordCount = 0;
                using (var reader = new StreamReader(filePath))
                {
                    // Read and ignore the header
                    if (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                    }

                    // Count the number of records
                    while (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                        recordCount++;
                    }
                }

                Console.WriteLine($"Total number of records (excluding header): {recordCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}
