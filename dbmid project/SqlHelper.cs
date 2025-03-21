using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace sqlhelper
{
    public class SqlHelper
    {
        public static string constring = "Server = localhost;Uid=root;Pwd=662373+azra-azra;Database=midprojectdb";
        public static void executeDML(string query)
        {
            using (var conn = new MySqlConnection(constring))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                    conn.Close(); // Ensure the connection is closed
                }
            }
        }

        public static DataTable getDataTable(string sql)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public static int GetRole(string sql)
        {
            int id = 0;
            MySqlConnection connection = new MySqlConnection(constring);
            connection.Open();
            MySqlCommand selectCmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = selectCmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);  // 0 is the column index
            }
            connection.Close();
            return id;

            
        }


        public static List<string> LoadIN_ComboBox(string sql, string s)
        {
            List<string> items = new List<string>();
            MySqlConnection connection = new MySqlConnection(constring);
            connection.Open(); ;
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                items.Add(reader[s].ToString()); 
            }
            reader.Close();
            connection.Close();
            return items;
        }
        public static void ExecuteTransaction(List<string> queries)
        {
            using (var conn = new MySqlConnection(constring))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var query in queries)
                        {
                            using (var cmd = new MySqlCommand(query, conn, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Transaction failed: " + ex.Message);
                    }
                }
            }
        }

        public static void InitializeRoles()
        {
            try
            {
                List<string> queries = new List<string>
                {
                    "SET FOREIGN_KEY_CHECKS = 0",
                    "DELETE FROM Roles",
                    "ALTER TABLE Roles AUTO_INCREMENT = 1",
                    "INSERT INTO Roles(role_name) SELECT DISTINCT value FROM lookup WHERE category='UserRoles' OR category='ParticipantRoles'",
                    "SET FOREIGN_KEY_CHECKS = 1" 
                };

                ExecuteTransaction(queries);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error initializing roles: " + ex.Message);
            }
        }

        public static void InitializeEventCategories()
        {
            try
            {
                List<string> queries = new List<string>
                {
                    "SET FOREIGN_KEY_CHECKS = 0",
                    "DELETE FROM Event_categories",
                    "ALTER TABLE Event_categories AUTO_INCREMENT = 1", 
                    "INSERT INTO Event_categories(category_name) SELECT value FROM lookup WHERE category='EventCategories'", 
                    "SET FOREIGN_KEY_CHECKS = 1" 
                };

                ExecuteTransaction(queries);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error initializing event categories: " + ex.Message);
            }
        }

        public static int CountRows(string query)
        {
            int count = 0;

            using (var conn = new MySqlConnection(constring))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return count;
        }
    }
}
