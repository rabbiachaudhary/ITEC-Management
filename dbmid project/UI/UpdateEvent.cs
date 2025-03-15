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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbmid_project
{
    public partial class UpdateEvent : Form
    {
        public UpdateEvent(string str)
        {
            
            InitializeComponent();


            if (str == "dlt")
            {
                LoadEvents();

                panel1.Visible = false;
                label1.Visible = false;
                button1.Visible = false;


                label8.Visible = true;
                label9.BringToFront();
                label9.Visible = true;

                comboBox5.BringToFront();
                comboBox5.Visible = true;
                button2.BringToFront();
                button2.Visible = true;
            }

            if (str == "update")
            {
                LoadEvents();

                LoadCommittees();
                LoadVenues();
                label8.Visible = false;
                label9.Visible = true;
                comboBox5.Visible = true;
                button2.Visible = false;


                panel1.Visible = true;
                label1.Visible = true;
                button1.Visible = true;
            }
        }
        private void UpdateEvent_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eventn = comboBox5.SelectedItem.ToString();
            EventsDL.DeleteEvent(eventn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eventn = comboBox5.SelectedItem.ToString();
            string newvenue = comboBox4.SelectedItem.ToString();
            string catnew = comboBox1.SelectedItem.ToString();
            string date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string newcom = comboBox3.SelectedItem.ToString();
            string newdes = textBox2.Text;

            EventsDL.Update(eventn, newvenue, catnew, date, newcom, newdes);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadCommittees()
        {
            int year = ITECedi.GetItec_Year();
            comboBox3.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select committee_name from committees where itec_id={0}";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "committee_name");

            foreach (string category in categories)
            {
                comboBox3.Items.Add(category); // Direct ComboBox me add
            }
        }



        private void LoadVenues()
        {
            int year = ITECedi.GetItec_Year();
            comboBox4.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select venue_name from venues";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "venue_name");

            foreach (string category in categories)
            {
                comboBox4.Items.Add(category); // Direct ComboBox me add
            }
        }

        private void LoadEvents()
        {
            int year = ITECedi.GetItec_Year();
            comboBox5.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select event_name from itec_events where itec_id={0}";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "event_name");

            foreach (string category in categories)
            {
                comboBox5.Items.Add(category); // Direct ComboBox me add
            }
        }
    }
}
