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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace dbmid_project
{
    public partial class Venue_Allocation : Form
    {
        public Venue_Allocation()
        {

            InitializeComponent();

            Load();

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Load()
        {
            listView2.Visible = true;

            DataTable d = ReportsDL.Getreport("Venue Allocations");
            listView2.Items.Clear();
            foreach (DataRow row in d.Rows)
            {
                ListViewItem item = new ListViewItem(row["event_name"].ToString());

                item.SubItems.Add(row["venue_name"].ToString());
                item.SubItems.Add(row["assigned_date"].ToString());
                listView2.Items.Add(item);

            }
        }
    }
}
