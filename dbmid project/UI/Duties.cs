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
    public partial class Duties : Form
    {
        public Duties()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new DutyCRUD("dlt"));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new DutyCRUD("update"));

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string committeeName = selectedItem.SubItems[0].Text; // Assuming Committee Name is the unique identifier
                string newStatus = e.ClickedItem.Text; // Get the new status from the clicked menu item

                // Update the status in the ListView
                selectedItem.SubItems[2].Text = newStatus;

                // Update the status in the database
                string query = $"UPDATE duties SET status_id = (select lookup_id from lookup where value='{0}') WHERE committee_id=(select committee_id from committees where committee_name='{1}'";
                query=string.Format(query, newStatus,committeeName);
                SqlHelper.executeDML(query);

                MessageBox.Show($"Status updated to {newStatus} for {committeeName}");
            }
        }
    }
}
