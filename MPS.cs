using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MPS_1
{
    internal class MPS
    {
        static public void mps(string x)
        {
            if(Int32.TryParse(x, out int n) && Int32.Parse(x) > 0)
            {
                string connectionString = "Server=bbdncuzehmllm2tlonqf-mysql.services.clever-cloud.com;Database=bbdncuzehmllm2tlonqf;User ID=utqahm0onvykd8nu;Password=3YB9aB945MPVN0Fk2H99;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Perform database operations
                        string query = "SELECT * FROM MPS WHERE Number = " + x;
                        MySqlCommand command = new MySqlCommand(query, connection);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    TextManip.Output($"Item No: {reader["Number"]}");
                                    TextManip.Output($"Title: {reader["Title"]}");
                                    TextManip.Output($"Object Class: {reader["Class"]}");
                                    TextManip.Output($"Rules of Thought:");
                                    TextManip.Output($"{reader["RlsOfThght"]}");
                                    TextManip.Output($"Definition:");
                                    TextManip.Output($"{reader["Desc"]}");
                                    if (reader["SciAdd"] != "")
                                    {
                                        TextManip.Output($"Scientific Addendum:");
                                        TextManip.Output($"{reader["SciAdd"]}");
                                    }
                                    if (reader["PrsnAdd"] != "")
                                    {
                                        TextManip.Output($"Personal Addendum:");
                                        TextManip.Output($"{reader["PrsnAdd"]}");
                                    }
                                }
                            }
                            else
                            {
                                TextManip.Output("Error: Attempting to access a non-existent file");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                TextManip.Output("Error: Attempted to enter a wrong number syntax");
            }
        }

        public static void list()
        {
            string connectionString = "Server=bbdncuzehmllm2tlonqf-mysql.services.clever-cloud.com;Database=bbdncuzehmllm2tlonqf;User ID=utqahm0onvykd8nu;Password=3YB9aB945MPVN0Fk2H99;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Perform database operations
                    string query = "SELECT Number, Title FROM MPS";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    { 
                        while(reader.Read())
                        {
                            int x = Int32.Parse(reader.GetString(0));
                            string y = x.ToString("D3");
                            TextManip.Output($"MPS-{y} - {reader["Title"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
