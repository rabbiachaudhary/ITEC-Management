using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbmid_project.DL;
using sqlhelper;

namespace dbmid_project
{
    public partial class ParticipantCRUD : Form
    {
        public ParticipantCRUD(string str)
        {
            InitializeComponent();
            LoadMembers();

            if (str == "update")
            {
                button2.Visible = false;
                label2.Visible = false;

            }
            if (str == "dlt")
            {
                label1.Visible = false;
                panel1.Visible = false;
            }
        }

        private void ParticipantCRUD_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = comboBox5.SelectedItem.ToString();
            ParticipantsDL.DeletePartcipant(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oname = comboBox5.SelectedItem.ToString();
            string newname = textBox1.Text;
            string email = textBox3.Text;
            string con = (textBox4.Text);
            string instituite = textBox2.Text;
            string role = comboBox1.SelectedItem.ToString();

            ParticipantsDL.Update(oname, newname, email, con, instituite, role);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void LoadMembers()
        {
            int year = ITECedi.GetItec_Year();
            comboBox5.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select name from participants where itec_id={0}";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "name");

            foreach (string category in categories)
            {
                comboBox5.Items.Add(category); // Direct ComboBox me add
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string name = comboBox5.SelectedItem.ToString();
            ParticipantsDL.DeletePartcipant(name);
        }
    }
}
