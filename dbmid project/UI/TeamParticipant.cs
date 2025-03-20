using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlhelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbmid_project
{
    public partial class TeamParticipant : Form
    {
        public TeamParticipant()
        {
            InitializeComponent();


            LoadEvents();
            LoadParticipants();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            // Clear existing items in the CheckedListBox
            checkedListBox1.Items.Clear();
            int year = ITECedi.GetItec_Year();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            // SQL query to fetch participant names
            string query = "SELECT Name FROM Participants where itec_id={0}";
            query = string.Format(query, id);
            // Use SqlHelper to get the data table
            DataTable dt = SqlHelper.getDataTable(query);

            // Create a list to store participant names
            List<string> participantNames = new List<string>();

            // Loop through the data table and add names to the list
            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                participantNames.Add(name);
            }

            // Add the list of names to the CheckedListBox
            checkedListBox1.Items.AddRange(participantNames.ToArray());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeamParticipant_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string team=textBox3.Text;
            string eventn = comboBox1.SelectedItem.ToString();
            int year = ITECedi.GetItec_Year();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            // SQL query to fetch participant names
            string query = "SELECT Name FROM Participants where itec_id={0}";
            query = string.Format(query, id);
            // Use SqlHelper to get the data table
            DataTable dt = SqlHelper.getDataTable(query);

            // Create a list to store participant names
            List<string> participantNames = new List<string>();

            // Loop through the data table and add names to the list
            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                participantNames.Add(name);

                TeamParticipant_FeeDialog f=new TeamParticipant_FeeDialog();
                this.Hide();
                f.ShowDialog();
            }



            
        }
    }
}
