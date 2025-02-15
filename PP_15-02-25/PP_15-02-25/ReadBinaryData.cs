using System;
using System.IO;
using System.Text;

namespace PP_15_02_25
{
    class ReadBinaryData
    {
        public static void Main7()
        {
            string filePath = "binarydata.bin";

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("File content as characters:");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
