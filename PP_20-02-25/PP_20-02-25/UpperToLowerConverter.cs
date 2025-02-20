using System;
using System.IO;
using System.Text;

namespace PP_20_02_25
{
    class UpperToLowerConverter
    {
        static void ConvertUppercaseToLowercase(string inputFilePath, string outputFilePath)
        {
            try
            {
                // Open input file with BufferedStream for efficiency
                using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (BufferedStream bufferedStream = new BufferedStream(inputStream))
                using (StreamReader reader = new StreamReader(bufferedStream, Encoding.UTF8))
                {
                    // Open output file with BufferedStream for efficiency
                    using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                    using (BufferedStream outputBuffered = new BufferedStream(outputStream))
                    using (StreamWriter writer = new StreamWriter(outputBuffered, Encoding.UTF8))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Convert to lowercase and write
                            writer.WriteLine(line.ToLower());
                        }
                    }
                }

                Console.WriteLine("File processing completed. Output saved to: " + outputFilePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        public static void Main6()
        {
            string inputFilePath = "..\\..\\TextFile1.txt";
            string outputFilePath = "..\\..\\TextFile2.txt";

            ConvertUppercaseToLowercase(inputFilePath, outputFilePath);
        }
    }
}
