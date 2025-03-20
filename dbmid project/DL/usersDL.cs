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

            string exist = "Count(*) From users where username='{0}'";
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
                        string query = "INSERT INTO users (username, email, password_hash, role_id) VALUES ('{0}', '{1}', '{2}', '{3}')";
                        query = string.Format(query, user.username, user.email, user.password, id);
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
            string query = "select role_id from users where username='{0}' and password_hash='{1}'";
            query= string.Format(query, name, pass);
            int idstr=SqlHelper.GetRole(query);
            return idstr;
        }
    }
}
