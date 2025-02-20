using System;
using System.IO;

namespace PP_20_02_25
{
    class ReadUserInput
    {
        public static void Main3()
        {
            try
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your age: ");
                string age = Console.ReadLine();

                Console.Write("Enter your favorite programming language: ");
                string language = Console.ReadLine();

                string filePath = "..\\..\\TextFile1.txt";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Name: " + name);
                    writer.WriteLine("Age: " + age);
                    writer.WriteLine("Favorite Programming Language: " + language);
                }

                Console.WriteLine("User information saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}
