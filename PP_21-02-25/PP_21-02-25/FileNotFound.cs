using System;
using System.IO;

namespace PP_21_02_25
{
    class FileNotFound
    {
        public static void Main1()
        {
            try
            {
                string filePath = "..\\..\\Program.cs";
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Contents:\n" + content);
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }

}
