using System;
using System.IO;

namespace PP_15_02_25
{
    class ReadFileLineByLine
    {
        public static void Main5()
        {
            string filePath = "..\\..\\Program.cs";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
