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
            checkedListBox1.Items.Clear();
            int year = ITECedi.GetItec_Year();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);



            string query = "SELECT Name FROM Participants where itec_id={0}";
            query = string.Format(query, id);


            DataTable dt = SqlHelper.getDataTable(query);

            List<string> participantNames = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                participantNames.Add(name);
            }

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
            try
            {
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Please enter a team name.");
                    return;
                }

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an event.");
                    return;
                }

                string team = textBox3.Text;
                string eventn = comboBox1.SelectedItem.ToString();

                List<string> participantNames = new List<string>();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    participantNames.Add(item.ToString());
                }

                if (participantNames.Count == 0)
                {
                    MessageBox.Show("Please select at least one participant.");
                    return;
                }
                teams t = new teams(team, eventn, participantNames);
                teamsDL.AddTeam(t);
                teamsDL.RegisterAsTeam(t);

                foreach (string name in participantNames)
                {
                    TeamParticipant_FeeDialog f = new TeamParticipant_FeeDialog();
                    f.SetParticipantName(name);
                    this.Hide();
                    f.ShowDialog();
                }

                MessageBox.Show("Team and participants registered successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
