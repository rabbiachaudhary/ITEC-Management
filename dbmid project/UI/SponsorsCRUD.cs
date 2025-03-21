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
    public partial class SponsorsCRUD : Form
    {
        public SponsorsCRUD(string str)
        {
            InitializeComponent();
            LoadCommittees();
            if (str == "dlt")
            {
                label1.Visible = false;

                panel1.Visible = false;
            }

            if (str == "update")
            {
                label2.Visible = false;
                button2.Visible = false;

            }

        }
        private void LoadCommittees()
        {
            string sql = "select sponsor_name from sponsors";
            sql = string.Format(sql);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "sponsor_name");

            foreach (string category in categories)
            {
                comboBox5.Items.Add(category);
            }
        }
        private void SponsorsCRUD_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = comboBox5.SelectedItem.ToString();
            SponsorsDL.Delete(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string oldname = comboBox5.SelectedItem.ToString();
            string name = textBox1.Text;
            string contact = textBox2.Text;
            SponsorBL s=new SponsorBL(name, contact);
            SponsorsDL.UpdateVendorInfo(oldname, s);
        }
    }
}
