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

            string com = comboBox2.SelectedItem.ToString();
            string act = comboBox1.SelectedItem.ToString();

            textBox2.Visible = false;
            label4.Visible = false;
            if (act == "Update")
            {
                textBox2.Visible = true;
                label4.Visible = true;
                string newn = textBox2.Text;

                CommitteeDL.Update(newn,com);

                MessageBox.Show("Updated");


            }
            else if (act == "Delete")
            {

                textBox2.Visible = false;
                label4.Visible = false;
                CommitteeDL.Delete(com);
                MessageBox.Show("deleted");

            }
            else
            {
                MessageBox.Show("Select Action");
            }

            LoadCategories();


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
            LoadCategories();

        }


        private void LoadCategories()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
        }
    }
}
