using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingSystem;

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
            string query = "select event_name, event_date, venue_id from itec_events where itec_id={0}";
            query=string.Format(query, year);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach(DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["event_name"].ToString());

                item.SubItems.Add(row["event_date"].ToString());
                item.SubItems.Add(row["venue_od"].ToString());
                listView1.Items.Add(item);

            }
        }


    }
}
