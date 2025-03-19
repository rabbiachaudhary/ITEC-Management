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
    public partial class AddTransaction : Form
    {
        public AddTransaction()
        {
            InitializeComponent();

            Events();

            LoadType();

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Events()
        {
            comboBox2.Items.Clear();

            int year = ITECedi.GetItec_Year();
            string sql = "select event_name from itec_events where itec_id=(select itec_id from itec_editions where year={0})";
            sql = string.Format(sql, year);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "event_name");

            foreach (string category in categories)
            {
                comboBox2.Items.Add(category); // Direct ComboBox me add
            }
        }


        private void LoadType()
        {
            comboBox1.Items.Clear();

            string sql = "select value from lookup where category='FinanceTypes'";
            sql = string.Format(sql);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "value");

            foreach (string category in categories)
            {
                comboBox1.Items.Add(category); // Direct ComboBox me add
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
