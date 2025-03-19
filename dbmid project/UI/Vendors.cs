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
    public partial class Vendors : Form
    {
        public Vendors()
        {
            InitializeComponent();

            LoadDataInListView();


        }

        private void Vendors_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataInListView()
        {
            int year = ITECedi.GetItec_Year();
            string query = "select vendor_name, service_type from vendors ";
            query = string.Format(query);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["vendor_name"].ToString());

                item.SubItems.Add(row["service_type"].ToString());
                listView1.Items.Add(item);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string contact = textBox2.Text;
            string type = textBox3.Text;
            VendorsBL v = new VendorsBL(name, contact, type);
            VendorsDL.AddVendors(v);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new VendorsCRUD("update"));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new VendorsCRUD("dlt"));
        }
    }
}
