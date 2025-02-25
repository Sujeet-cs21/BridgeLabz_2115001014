using System;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Class11
    {
        public static void Main11()
        {
            string filePath = "..\\..\\large_data.csv"; 
            int batchSize = 100;
            int totalRecords = 0;

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(filePath);

                // Read and discard header
                string header = reader.ReadLine();
                Console.WriteLine("Processing CSV file...");

                string line;
                int batchCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    batchCount++;
                    totalRecords++;


                    // When batchSize is reached, print progress and reset counter
                    if (batchCount == batchSize)
                    {
                        Console.WriteLine($"Processed {totalRecords} records...");
                        batchCount = 0;
                    }
                }

                Console.WriteLine($"Finished processing. Total records: {totalRecords}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The CSV file was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
