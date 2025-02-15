using System;
using System.IO;

namespace PP_15_02_25
{
    class WriteToFile
    {
        public static void Main8()
        {
            string filePath = "..\\..\\TextFile1.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    Console.WriteLine("Enter text to write to the file (type 'exit' to stop):");

                    while (true)
                    {
                        string input = Console.ReadLine();
                        if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            break;

                        writer.WriteLine(input);
                    }
                }

                Console.WriteLine($"User input successfully written to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
