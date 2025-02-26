using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;

namespace PP_26_02_25_json
{
    class Class13
    {
        public static void Main13()
        {
            string connectionString = "connection_string";
            string query = "SELECT Id, Name, Age, Email FROM Users";

            try
            {
                // Fetch data from the database
                DataTable dataTable = GetDataFromDatabase(connectionString, query);

                // Convert DataTable to JSON
                string jsonReport = JsonConvert.SerializeObject(dataTable, Formatting.Indented);

                // Print JSON report
                Console.WriteLine("Generated JSON Report:\n" + jsonReport);

                // Save JSON report to a file
                File.WriteAllText("Report.json", jsonReport);
                Console.WriteLine("Report saved as 'Report.json'");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generating JSON report: " + ex.Message);
            }
        }

        static DataTable GetDataFromDatabase(string connectionString, string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }
    }
}
