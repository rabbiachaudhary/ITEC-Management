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
    public partial class AddDuties : Form
    {
        public AddDuties()
        {
            InitializeComponent();

            LoadCom();
            LoadMembers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadCom()
        {
            int year = ITECedi.GetItec_Year();
            comboBox2.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select committee_name from committees where itec_id={0}";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "committee_name");

            foreach (string category in categories)
            {
                comboBox2.Items.Add(category); // Direct ComboBox me add
            }
        }


        private void LoadMembers()
        {
            string com = comboBox2.SelectedItem.ToString();
            int year = ITECedi.GetItec_Year();
            comboBox1.Items.Clear();
            string sql = "select name from committee_members where committee_id=(select committee_id from committees where committee_name='{0}'";
            sql = string.Format(sql, com);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "name");

            foreach (string category in categories)
            {
                comboBox1.Items.Add(category); // Direct ComboBox me add
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string com= comboBox2.SelectedItem.ToString();
            string member= comboBox1.SelectedItem.ToString();
            string desc = textBox2.Text;
            string date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string status = comboBox3.SelectedItem.ToString();
            DutiesBL d=new DutiesBL(com,member,desc,date,status);
            DutiesDL.AddDuties(d);
        }

    }
}
