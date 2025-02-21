using System;
using System.IO;

namespace PP_21_02_25
{
    class FileHandling
    {
        public static void Main5()
        {
            try
            {
                using (StreamReader reader = new StreamReader("..\\..\\Program.cs"))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine("First line of file: " + firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }

}
