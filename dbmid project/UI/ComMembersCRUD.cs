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
using sqlhelper;

namespace dbmid_project
{
    public partial class ComMembersCRUD : Form
    {
        public ComMembersCRUD(string str)
        {
            InitializeComponent();
            LoadMembers();


            if (str == "dlt")
            {
                label1.Visible = false;
                panel1.Visible = false;




                label2.Visible = true;
                button2.Visible = true;
            }
            if (str == "update")
            {

                LoadCommittees();
                LoadRoles();
                label2.Visible = false;
                button2.Visible = false;



                label1.Visible = true;
                panel1.Visible = true;


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = comboBox5.SelectedItem.ToString();
            CommitteeMembersDL.Delete(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldname = comboBox5.SelectedItem.ToString();

            string newname = textBox1.Text;

            string com = comboBox1.SelectedItem.ToString();
            string role = comboBox2.SelectedItem.ToString();
            CommitteeMembersDL.Update(oldname, newname, com, role);
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


        private void LoadMembers()
        {
            int year = ITECedi.GetItec_Year();
            comboBox5.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select name from committee_members";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "name");

            foreach (string category in categories)
            {
                comboBox5.Items.Add(category); // Direct ComboBox me add
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

        private void ComMembersCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
