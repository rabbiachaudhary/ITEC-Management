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
    }
}
