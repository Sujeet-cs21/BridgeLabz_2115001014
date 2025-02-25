using System;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Class2
    {
        public static void Main2()
        {
            string filePath = "..\\..\\employees.csv";

            //employee data
            string[] employees =
            {
            "ID,Name,Department,Salary",
            "201,Abc,HR,55000",
            "202,Bcd,IT,70000",
            "203,Cdc,Finance,60000",
            "204,Def,Marketing,65000",
            "205,Efg,IT,72000"
        };

            try
            {
                // Writing data to CSV file
                File.WriteAllLines(filePath, employees);
                Console.WriteLine($"CSV file '{filePath}' created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing file: {ex.Message}");
            }
        }
    }
}
