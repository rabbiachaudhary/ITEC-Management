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
    public partial class MemberinCom : Form
    {
        public MemberinCom()
        {
            InitializeComponent();
            LoadCommittees();

            LoadRoles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new MemberinCom());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadDataInListView()
        {
            int year = ITECedi.GetItec_Year();
            string query = "select name, role_id from committee_members where itec_id={0} and committe_id={1}";
            query = string.Format(query, year);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["event_name"].ToString());

                item.SubItems.Add(row["event_date"].ToString());
                item.SubItems.Add(row["venue_od"].ToString());
                listView1.Items.Add(item);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new ComMembersCRUD("update"));


        }

        private void LoadCommittees()
        {
            int year = ITECedi.GetItec_Year();
            comboBox1.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select committee_name from committees where itec_id={0}";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "committee_name");

            foreach (string category in categories)
            {
                comboBox1.Items.Add(category); // Direct ComboBox me add
            }
        }


        private void LoadRoles()
        {
            int year = ITECedi.GetItec_Year();
            comboBox2.Items.Clear();
            string sql = "select value from lookup where category='CommitteeRoles'";
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "value");

            foreach (string category in categories)
            {
                comboBox2.Items.Add(category); // Direct ComboBox me add
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string role = comboBox2.SelectedItem.ToString();
            string com = comboBox1.SelectedItem.ToString();
            CommitteeMembersBL c = new CommitteeMembersBL(name, role, com);
            CommitteeMembersDL.AddCommittee(c);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new UpdateEvent("dlt"));


        }
    }
}
