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
    public partial class AddResults : Form
    {
        public AddResults()
        {
            InitializeComponent();

            LoadTeams();
            LoadPositions();
            LoadEvents();
        }
        string eventn = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string eventn = comboBox2.SelectedItem.ToString();
            string participant = textBox1.Text;
            string team = comboBox3.SelectedItem.ToString();
            string position = comboBox1.SelectedItem.ToString();
            float score = float.Parse(textBox2.Text);
            string remarks = textBox3.Text;
            ResultsBL r = new ResultsBL(eventn, participant, team, position, score, remarks);
            ResultsDL.AddResults(r);
        }

        private void LoadEvents()
        {
            comboBox2.Items.Clear();
            int year = ITECedi.GetItec_Year();


            string sql = "select event_name from itec_events where itec_id=(select itec_id from itec_editions where year={0})";
            sql = string.Format(sql, year);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "event_name");

            foreach (string category in categories)
            {
                comboBox2.Items.Add(category); // Direct ComboBox me add
            }

        }

        private void LoadPositions()
        {
            comboBox1.Items.Clear();
            int year = ITECedi.GetItec_Year();


            string sql = "select value from lookup where category='EventPositions'";
            sql = string.Format(sql, year);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "value");

            foreach (string category in categories)
            {
                comboBox1.Items.Add(category); // Direct ComboBox me add
            }
        }


        private void LoadTeams()

        {

            comboBox3.Items.Clear();

            string sql = "select team_name from teams where event_id =(select event_id from itec_events where event_name='{0}')";


            sql = string.Format(sql, eventn);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "team_name");

            foreach (string category in categories)
            {
                comboBox3.Items.Add(category); // Direct ComboBox me add
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventn = comboBox2.SelectedItem.ToString();
            LoadTeams();
        }
    }
}
