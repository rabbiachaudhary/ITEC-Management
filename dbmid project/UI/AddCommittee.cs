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
    public partial class AddCommittee : Form
    {
        public AddCommittee()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new MemberinCom());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = ITECedi.GetItec_Year();
            comboBox2.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);

            string name = textBox1.Text;
            CommitteeBL c = new CommitteeBL(id, name);

            CommitteeDL.AddCommittee(c);

        }


        private void LoadCategories()
        {
            int year = ITECedi.GetItec_Year();
            comboBox2.Items.Clear();
            string itecid = "select itec_id from itec_editions where year={0}";
            itecid = string.Format(itecid, year);
            int id = SqlHelper.GetRole(itecid);
            string sql = "select event_name from itec_events where itec_id={0}";
            sql = string.Format(sql, id);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "event_name");

            foreach (string category in categories)
            {
                comboBox2.Items.Add(category); // Direct ComboBox me add
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
