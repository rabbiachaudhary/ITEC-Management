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
using sqlhelper;
using dbmid_project.DL;

namespace dbmid_project
{
    public partial class AddTransaction : Form
    {
        public AddTransaction()
        {
            InitializeComponent();

            Events();

            LoadType();

            LoadEntityTypes();

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

        private void LoadEntityTypes()
        {
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            string sql = "select value from lookup where category='EntityTypes'";
            sql = string.Format(sql);
            List<string> categories = SqlHelper.LoadIN_ComboBox(sql, "value");

            foreach (string category in categories)
            {
                comboBox3.Items.Add(category);
                comboBox4.Items.Add(category);

            }
        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eventn = comboBox2.SelectedItem.ToString();
            string Finance = comboBox1.SelectedItem.ToString();
            float amount=float.Parse(textBox1.Text);
            string description = textBox2.Text;
            string date = monthCalendar1.ToString();
            string sname=textBox3.Text;
            string stype=comboBox3.SelectedItem.ToString();
            string rname=textBox4.Text;
            string rtype=comboBox4.Text;
            TransactionsBL t=new TransactionsBL(eventn,Finance,amount, description, date, sname, stype, rname,rtype);

            TransactionsDL.AddTransaction(t);
        }
    }
}
