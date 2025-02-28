using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;



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
            StudentDashboard s=new StudentDashboard();
            this.Hide();
            s.Show();
        }

        private void Button_click(object sender, EventArgs e)
        {
            AdminDashboard a=new AdminDashboard();
            this.Hide();
            a.Show();
        }

    }
}

