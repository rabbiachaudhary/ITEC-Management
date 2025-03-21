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

namespace dbmid_project
{
    public partial class View_Committees : Form
    {
        public View_Committees()
        {
            InitializeComponent();
            LoadDataInListView();

               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadDataInListView()
        {
            int year = ITECedi.GetItec_Year();
            string query = "select committee_name from  committees where year={0}";
            query = string.Format(query,year);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["committee_name"].ToString());

                listView1.Items.Add(item);

            }
        }
    }
}
