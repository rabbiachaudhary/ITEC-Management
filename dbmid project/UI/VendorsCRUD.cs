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
    public partial class VendorsCRUD : Form
    {
        public VendorsCRUD(string str)
        {

            LoadCommittees();

            InitializeComponent();

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

        private void VendorsCRUD_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void LoadCommittees()
        {
            string sql = "select vendor_name from vendors";
            sql = string.Format(sql);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "vendor_name");

            foreach (string category in categories)
            {
                comboBox5.Items.Add(category);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = comboBox5.SelectedItem.ToString();
            VendorsDL.DeleteVendor(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldname = comboBox5.SelectedItem.ToString();
            string name = textBox1.Text;
            string contact=textBox2.Text;
            string type=textBox3.Text;

            VendorsBL update=new VendorsBL(name, contact, type);
            VendorsDL.UpdateVendorInfo(oldname, update);
        }
    }
}
