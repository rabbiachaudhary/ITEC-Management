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
    public partial class TrackFees : Form
    {
        public TrackFees()
        {
            InitializeComponent();

            LoadDataInListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadDataInListView()
        {

            int year = ITECedi.GetItec_Year();
            string query = "select event_name, name, fee_amount,value from event_participants ep join itec_events e on e.event_id=ep.event_id join participants p on ep.participant_id=p.participant_id join lookup l on ep.payment_status_id=l.lookup_id where e.itec_id=(select itec_id from itec_editions where year={0})";
            query = string.Format(query, year);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["event_name"].ToString());

                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["fee_amount"].ToString());
                item.SubItems.Add(row["value"].ToString());
                listView1.Items.Add(item);

            }
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
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
                    string pName = selectedItem.SubItems[1].Text;

                    string newStatus = e.ClickedItem.Text;
                    selectedItem.SubItems[3].Text = newStatus;
                    string sql = "(SELECT registration_id FROM event_participants WHERE event_id = (select event_id from itec_events where event_name='{0}' ) and participant_id=(select participant_id from participants where name='{1}'))";
                    sql= string.Format(sql, committeeName, pName);
                    int id = SqlHelper.GetRole(sql);

                    string query = @"
            UPDATE event_participants 
            SET payment_status_id = (SELECT lookup_id FROM lookup WHERE value = '{0}' and category='PaymentStatus') 
            WHERE registration_id = {1}";
                    query = string.Format(query, newStatus, id );

                    SqlHelper.executeDML(query);

                    MessageBox.Show($"Status updated to {newStatus} ");
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
    }
}
