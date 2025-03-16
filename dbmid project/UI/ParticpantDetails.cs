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
    public partial class ParticpantDetails : Form
    {
        public ParticpantDetails()
        {
            InitializeComponent();
            LoadDataInListView();
        }

        private void ParticpantDetails_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataInListView()
        {
            int year = ITECedi.GetItec_Year();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string query = "select name, email, event_name, value , fee_amount from participants p join event_participants ep on p.participant_id=ep.participant_id join lookup l on l.lookup_id=ep.payment_status_id join itec_events ie on ie.event_id=ep.event_id where p.itec_id={0} ";
            query = string.Format(query, id);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["name"].ToString());

                item.SubItems.Add(row["email"].ToString());
                item.SubItems.Add(row["event_name"].ToString());
                item.SubItems.Add(row["value"].ToString());

                item.SubItems.Add(row["fee_amount"].ToString());


                listView1.Items.Add(item);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string eventn = textBox1.Text;
            Search(eventn);
        }


        private void Search(string name)
        {
            int year = ITECedi.GetItec_Year();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string query = "select name, email, event_name, value , fee_amount from participants p join event_participants ep on p.participant_id=ep.participant_id join lookup l on l.lookup_id=ep.payment_status_id join itec_events ie on ie.event_id=ep.event_id where p.itec_id={0} and event_name='{1}'";
            query = string.Format(query, id, name);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["name"].ToString());

                item.SubItems.Add(row["email"].ToString());
                item.SubItems.Add(row["event_name"].ToString());
                item.SubItems.Add(row["value"].ToString());

                item.SubItems.Add(row["fee_amount"].ToString());

                listView1.Items.Add(item);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new ParticipantCRUD("update"));

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new ParticipantCRUD("dlt"));

        }
    }
}
