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
    public partial class Addevent : Form
    {
        public Addevent()
        {
            InitializeComponent();

            LoadCommittees();


            LoadVenues();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string name = textBox1.Text;
            string venue = comboBox2.SelectedItem.ToString();
            string category = comboBox1.SelectedItem.ToString();
            string date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string description = textBox2.Text;
            string Committee = comboBox3.SelectedItem.ToString();
            EventsBL events = new EventsBL(name, category, description, date, venue, Committee);
            EventsDL.AddEvent(events);
        }

        private void Addevent_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string name = textBox1.Text;
            string venue = comboBox2.SelectedItem.ToString();
            string category = comboBox1.SelectedItem.ToString();
            string date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string description = textBox2.Text;
            string Committee = comboBox3.SelectedItem.ToString();
            EventsBL events = new EventsBL(name, category, description, date, venue, Committee);

            EventsDL.AddEvent(events);


            AdminDashboard mainForm = (AdminDashboard)this.ParentForm;
            mainForm.OpenFormInPanel(new AddCommittee());
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
            comboBox2.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select venue_name from venues";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "venue_name");

            foreach (string category in categories)
            {
                comboBox2.Items.Add(category); // Direct ComboBox me add
            }
        }


    }
}
