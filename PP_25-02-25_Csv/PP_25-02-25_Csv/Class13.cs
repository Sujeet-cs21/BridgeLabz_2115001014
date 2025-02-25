using System;
using System.Data.SqlClient;
using System.IO;

namespace PP_25_02_25_Csv
{
    class Class13
    {
        public static void Main13()
        {
            string connectionString = "your_connection_string";
            string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
            string csvFilePath = "..\\..\\employee.csv";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    using (StreamWriter writer = new StreamWriter(csvFilePath))
                    {
                        // Write CSV Header
                        writer.WriteLine("Employee ID,Name,Department,Salary");

                        // Write Data Rows
                        while (reader.Read())
                        {
                            string id = reader["EmployeeID"].ToString();
                            string name = reader["Name"].ToString();
                            string department = reader["Department"].ToString();
                            string salary = reader["Salary"].ToString();

                            writer.WriteLine($"{id},{name},{department},{salary}");
                        }
                    }
                }

                Console.WriteLine($"CSV report generated successfully: {csvFilePath}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database Error: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }
    }
}
