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
    public partial class View_Committees : Form
    {
        public View_Committees()
        {
            InitializeComponent();

            ListViewItem item = new ListViewItem("oooo");
            item.SubItems.Add("bbbbbbbbbbbb");
            item.SubItems.Add("jjjjjjjjjjj");
            item.SubItems.Add(":");
            listView1.Items.Add(item);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
