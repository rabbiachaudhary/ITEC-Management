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
    public partial class Sponsors : Form
    {
        public Sponsors()
        {
            InitializeComponent();
            LoadDataInListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string contact = textBox2.Text;
            SponsorBL v = new SponsorBL(name, contact);
            SponsorsDL.Adds(v);
        }

        private void LoadDataInListView()
        {
            int year = ITECedi.GetItec_Year();
            string query = "select sponsor_name,contact from sponsors";
            query = string.Format(query);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["sponsor_name"].ToString());

                item.SubItems.Add(row["contact"].ToString());
                listView1.Items.Add(item);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new SponsorsCRUD("update"));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new SponsorsCRUD("dlt"));
        }
    }
}
