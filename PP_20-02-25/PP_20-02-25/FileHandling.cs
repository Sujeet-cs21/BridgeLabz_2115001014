using System;
using System.IO;

namespace PP_20_02_25
{
    class FileHandling
    {
        public static void Main1()
        {
            string sourceFilePath = "..\\..\\TextFile1.txt";
            string destinationFilePath = "..\\..\\TextFile2.txt";

            try
            {
                // Check if the source file exists
                if (!File.Exists(sourceFilePath))
                {
                    Console.WriteLine("Error: Source file does not exist.");
                    return;
                }

                // Open FileStream for reading from source file
                using (FileStream fsRead = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fsRead))
                {
                    // Open FileStream for writing to destination file
                    using (FileStream fsWrite = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
                    using (StreamWriter writer = new StreamWriter(fsWrite))
                    {
                        // Read all content from the source fil
                        string content = reader.ReadToEnd();
                        // Write content to the destination file
                        writer.Write(content);
                        Console.WriteLine("File copied successfully.");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An IO exception occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
