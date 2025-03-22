using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbmid_project
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        public void OpenFormInPanel(Form form)
        {
            panel3.Controls.Clear(); // Remove previous form
            form.TopLevel = false;  // Set as child control
            form.FormBorderStyle = FormBorderStyle.None;  // Remove window border
            form.Dock = DockStyle.Fill;  // Make it fill the panel
            panel3.Controls.Add(form);  // Add to panel
            form.Show();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new ITECedi());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ITECedi.GetItec_Year() == 0)
            {
                MessageBox.Show("Select ITEC edition first");
            }
            else
            {
                OpenFormInPanel(new Events());
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ITECedi.GetItec_Year() == 0)
            {
                MessageBox.Show("Select ITEC edition first");
            }
            else
            {
                OpenFormInPanel(new RegisterParticipants());
            }
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ITECedi.GetItec_Year() == 0)
            {
                MessageBox.Show("Select ITEC edition first");
            }
            else
            {
                OpenFormInPanel(new Duties());
            }

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ITECedi.GetItec_Year() == 0)
            {
                MessageBox.Show("Select ITEC edition first");
            }
            else
            {
                OpenFormInPanel(new View_Committees());
            }
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ITECedi.GetItec_Year() == 0)
            {
                MessageBox.Show("Select ITEC edition first");
            }
            else
            {
                OpenFormInPanel(new Results());
            }
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new ITECedi());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

            Login a = new Login();
            this.Hide();
            a.Show();
        }
    }
}
