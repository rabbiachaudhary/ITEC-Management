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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            OpenFormInPanel(new ITECedi());
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFormInPanel(new Events());
        }
        public void OpenFormInPanel(Form form)
        {
            pnlContent.Controls.Clear(); // Remove previous form
            form.TopLevel = false;  // Set as child control
            form.FormBorderStyle = FormBorderStyle.None;  // Remove window border
            form.Dock = DockStyle.Fill;  // Make it fill the panel
            pnlContent.Controls.Add(form);  // Add to panel
            form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new Addevent());

        }

        private void ss(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new RegisterParticipants());

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new RegTypesNDFees());
        }

        private void linkLabel15_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFormInPanel(new ITECedi());
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new ParticpantDetails());
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new AddCommittee());
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new View_Committees());
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new AddDuties());
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new AddTransaction());
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormInPanel(new AddResults());
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



