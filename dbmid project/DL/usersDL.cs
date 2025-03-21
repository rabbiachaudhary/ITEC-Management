using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sqlhelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using dbmid_project.BL;
using MySql.Data.MySqlClient;
using System.Data;

namespace dbmid_project.DL
{
    public class usersDL
    {
        public static int GetId(string a)
        {
            int id=-1;


            if (a == "Admin")
            {
                id = 1;
            }
            else if (a == "Faculty")
            {
                id = 2;
            }
            else if (a== "Student ")
            {
                id = 3;
            }
            else if (a == "Sponsor")
            {
                id = 4;
            }

            return id;
        }

        public static string RegisterUser(usersBL user)
        {

            string exist = " select Count(*) From users where username='{0}'";
            exist = string.Format(exist, user.username);
            int count = SqlHelper.CountRows(exist);
            if (count > 0)
            {
                MessageBox.Show("This username already exits try a different one");
                return "existx";
            }

            else
            {


                try
                {
                    if (user.password == user.cpass)
                    {
                        int id = GetId(user.role);
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.password);
                        string query = "INSERT INTO users (username, email, password_hash, role_id) VALUES ('{0}', '{1}', '{2}', (select role_id from roles where role_name='{3}'))";
                        query = string.Format(query, user.username, user.email, hashedPassword, user.role);
                        MessageBox.Show(query);

                        SqlHelper.executeDML(query);
                        MessageBox.Show("User registered successfully!");
                        if (id == 1)
                        {
                            return "Admin";
                        }
                        if (id == -1)
                        {
                            return "Invalid role!";
                        }
                        return "stu";

                    }
                    return "password dont match";
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        return "This Username already exists";
                    }
                    return "try again";
                }
            }
        }

        public static int Role(string name, string pass)
        {
            int roleId = -1;
            string storedHash = "";

            string query = $"SELECT role_id, password_hash FROM users WHERE username = '{name}'";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0)
            {
                roleId = Convert.ToInt32(dt.Rows[0]["role_id"]);
                storedHash = dt.Rows[0]["password_hash"].ToString();
            }

            // Check if entered password matches the hashed password
            if (!string.IsNullOrEmpty(storedHash) && BCrypt.Net.BCrypt.Verify(pass, storedHash))
            {
                return roleId; // Login successful
            }

            return -1; // Login failed
        }
    }
}
