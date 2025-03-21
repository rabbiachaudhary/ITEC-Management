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

            LoadDataInListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;

        }

        private void button1_Click(object sender, EventArgs e)
        {



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
                try
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];

                    string committeeName = selectedItem.SubItems[0].Text; 
                    string newStatus = e.ClickedItem.Text; 
                    selectedItem.SubItems[3].Text = newStatus; 
                    string query = @"
            UPDATE duties 
            SET status_id = (SELECT lookup_id FROM lookup WHERE value = '{0}') 
            WHERE committee_id = (SELECT committee_id FROM committees WHERE committee_name = '{1}')";
                    query = string.Format(query, newStatus, committeeName);

                    SqlHelper.executeDML(query);

                    MessageBox.Show($"Status updated to {newStatus} for {committeeName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a committee to update.");
            }
        }

        private void Duties_Load(object sender, EventArgs e)
        {
            Form parentForm = this.TopLevelControl as Form;

            if (parentForm is StudentDashboard)
            {
                button1.Visible = false;
                button2.Visible = false;
                contextMenuStrip1.Visible = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadDataInListView()
        {
            string query = "select committee_name, assigned_to, task_description, deadline, value from duties d join committees c on d.committee_id=c.committee_id join lookup l on l.lookup_id=d.status_id";
            query = string.Format(query);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["committee_name"].ToString());

                item.SubItems.Add(row["assigned_to"].ToString());
                item.SubItems.Add(row["deadline"].ToString());
                item.SubItems.Add(row["value"].ToString());
                listView1.Items.Add(item);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
