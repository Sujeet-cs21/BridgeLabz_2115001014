using System.IO;

namespace PP_22_02_25_NUnit
{
    public class FileProcessor
    {
        public void WriteToFile(string filename, string content)
        {
            try
            {
                File.WriteAllText(filename, content);
            }
            catch (IOException ex)
            {
                throw new IOException("Error writing to file.", ex);
            }
        }

        public string ReadFromFile(string filename)
        {
            try
            {
                return File.ReadAllText(filename);
            }
            catch (IOException ex)
            {
                throw new IOException("Error reading from file.", ex);
            }
        }
    }
}
