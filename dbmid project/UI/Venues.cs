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
    public partial class Venues : Form
    {
        public Venues()
        {
            InitializeComponent();

            LoadDataInListView();
        }

        private void Venues_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataInListView()
        {

            string query = "select venue_name,capacity,location from venues ";
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["venue_name"].ToString());

                item.SubItems.Add(row["capacity"].ToString());
                item.SubItems.Add(row["location"].ToString());
                listView1.Items.Add(item);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string name = textBox2.Text;
            int capacity = int.Parse(textBox3.Text);
            string location = textBox1.Text;

            venueBL v = new venueBL(name, location, capacity);
            venueDL.AddVenue(v);


            LoadDataInListView();
        }
    }
}
