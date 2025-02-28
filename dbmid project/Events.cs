using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbmid_project
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();

            ListViewItem item = new ListViewItem("Tech Conference 2025");
            item.SubItems.Add("New York Convention Center");
            item.SubItems.Add("March 10, 2025");
            item.SubItems.Add(":");
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
