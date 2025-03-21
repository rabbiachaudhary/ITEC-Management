using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbmid_project.BL;
using dbmid_project.DL;
using sqlhelper;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using BCrypt.Net;

namespace dbmid_project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            LoadRoles();
        }
        private void Signup_Button(object sender, EventArgs e)
        {
            string username = textBox4.Text;
            string email = textBox10.Text;
            string pass = textBox9.Text;
            string cpass = textBox8.Text;
            string role = comboBox1.SelectedItem.ToString();

            usersBL user = new usersBL(username, pass, email, role, cpass);
            string a = usersDL.RegisterUser(user);
            if (a == "Admin")
            {
                AdminDashboard ad = new AdminDashboard();
                this.Hide();
                ad.Show();
            }
            else if (a == "stu")
            {

                StudentDashboard b = new StudentDashboard();
                this.Hide();

                b.Show();
            }
            else if (a == "password dont match")
            {
                MessageBox.Show("password dont match");
            }
            else if (a == "This Username already exists" || a == "fill all the fields" || a == "invalid role" || a == "try again")
            {
                MessageBox.Show(a);
            }
            else if (role == "")
            {
                MessageBox.Show("Select Role");
            }
            else
            {
                int id = usersDL.Role(username, pass);
                if (id == 1)
                {
                    AdminDashboard admin = new AdminDashboard();
                    this.Hide();
                    admin.Show();
                }
                if (id == 2 || id == 3 || id == 4)
                {
                    StudentDashboard stu = new StudentDashboard();
                    this.Hide(); stu.Show();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }


        private void LoadRoles()

        {
            comboBox1.Items.Clear();
            string sql = "select value from lookup where category='UserRoles'";
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "value");

            foreach (string category in categories)
            {
                comboBox1.Items.Add(category); // Direct ComboBox me add
            }
        }

    }
}
