using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using dbmid_project.DL;
using MySql.Data.MySqlClient;



namespace dbmid_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s=new SignUp();
            this.Hide();
            s.Show();
        }

        private void Button_click(object sender, EventArgs e)
        {
            string name=textBox1.Text;
            string pass=textBox2.Text;  
            int id=usersDL.Role(name, pass);
            if (id == 1)
            {
                AdminDashboard a=new AdminDashboard();
                this.Hide();
                a.Show();   
            }
            if(id==2 || id==3 || id == 4)
            {
                StudentDashboard a=new StudentDashboard();
                this.Hide(); a.Show();
            }
        }

    }
}

