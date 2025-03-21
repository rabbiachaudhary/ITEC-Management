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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            LoadDataInListView();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Events_Load(object sender, EventArgs e)
        {
            Form parentForm = this.TopLevelControl as Form;

            if (parentForm is StudentDashboard)
            {
                listView1.Columns[3].Width = 0;

            }
        }

        private void LoadDataInListView()
        {
            int year = ITECedi.GetItec_Year();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string query = "select event_name, event_date, venue_name from itec_events i join venues v on i.venue_id=v.venue_id where itec_id={0}";
            query = string.Format(query, id);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["event_name"].ToString());

                item.SubItems.Add(row["event_date"].ToString());
                item.SubItems.Add(row["venue_name"].ToString());
                listView1.Items.Add(item);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new UpdateEvent("update"));




        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new UpdateEvent("dlt"));


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Search(name);
        }


        private void Search(string name)
        {
            int year = ITECedi.GetItec_Year();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string query = "select event_name, event_date, venue_id from itec_events where itec_id={0} and event_name = '{1}'";
            query = string.Format(query, id,name);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["event_name"].ToString());

                item.SubItems.Add(row["event_date"].ToString());
                item.SubItems.Add(row["venue_id"].ToString());
                listView1.Items.Add(item);

            }
        }
    }
}
