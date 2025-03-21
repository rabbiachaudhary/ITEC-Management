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
    public partial class EditionsCRUD : Form
    {
        public EditionsCRUD(string str)
        {
            InitializeComponent();

            LoadCategories();
            if (str == "update")
            {
                label2.Visible = false;
                button2.Visible = false;
            }
            if (str == "dlt")
            {
                label1.Visible = false;
                panel1.Visible = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadCategories()
        {
            comboBox5.Items.Clear();
            string sql = "select year from itec_editions";
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "year");

            foreach (string category in categories)
            {
                comboBox5.Items.Add(category);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldyear = comboBox5.SelectedItem.ToString();
            int year = int.Parse(textBox2.Text);
            string theme = textBox1.Text;
            string descriotion = textBox3.Text;
            ITECeditionBL itec = new ITECeditionBL(year, theme, descriotion);
            ITECeditionDL.UpdateEdition(oldyear, itec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oldyear =comboBox5.SelectedItem.ToString();

            ITECeditionDL.DeleteEdition(oldyear);
        }
    }
}
