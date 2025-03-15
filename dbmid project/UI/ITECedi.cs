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
using MySql.Data.MySqlClient;

namespace dbmid_project
{
    public partial class ITECedi : Form
    {
        public static int year { get; set; }
        public ITECedi()
        {
            InitializeComponent();

            LoadCategories();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ITECedi_Load(object sender, EventArgs e)
        {

        }

        private void ITECedi_Load_1(object sender, EventArgs e)
        {
            Form parentForm = this.TopLevelControl as Form; // Gets the main form (Dashboard)

            if (parentForm is StudentDashboard)
            {
                panel1.Visible = false;

                label4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox2.Text);
            string theme = textBox1.Text;
            string description = textBox3.Text;
            ITECeditionBL itec = new ITECeditionBL(year, theme, description);
            ITECeditionDL.AddEdition(itec);
        }

        private void LoadCategories()
        {
            comboBox1.Items.Clear();
            string sql = "select year from itec_editions";
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql,"year");

            foreach (string category in categories)
            {
                comboBox1.Items.Add(category); // Direct ComboBox me add
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             year=int.Parse( comboBox1.SelectedItem.ToString());
            MessageBox.Show("edition selected " + year);

        }

        public static int GetItec_Year()
        {
            return year;
        }

    }
}
