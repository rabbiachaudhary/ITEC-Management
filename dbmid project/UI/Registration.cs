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

using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            LoadEvents();
            LoadParticipants();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadEvents()
        {
            int year = ITECedi.GetItec_Year();
            comboBox1.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select event_name from itec_events where itec_id={0}";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "event_name");

            foreach (string category in categories)
            {
                comboBox1.Items.Add(category);
            }


        }
        private void LoadParticipants()
        {
            int year = ITECedi.GetItec_Year();
            comboBox2.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select name from participants where itec_id={0}";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "name");

            foreach (string category in categories)
            {
                comboBox2.Items.Add(category);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eventn = comboBox2.SelectedItem.ToString();
            string parti = comboBox1.SelectedItem.ToString();
            string status = comboBox3.SelectedItem.ToString();

            int amount = int.Parse(textBox1.Text);


            RegisterPartcipantsBL b = new RegisterPartcipantsBL(parti, eventn, status, amount);
            RegisterParticipantDL.Register(b);
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
