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


namespace dbmid_project
{
    public partial class RegisterParticipants : Form
    {
        public RegisterParticipants()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox3.Text;
            string contact = (textBox4.Text);

            string institute = textBox2.Text;
            string role = comboBox1.SelectedItem.ToString();

            Partcipants p = new Partcipants(name, email, contact, institute, role);
            ParticipantsDL.AddEvent(p);


        }

        private void RegisterParticipants_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
