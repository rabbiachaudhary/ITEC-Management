using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbmid_project
{
    public partial class ComMembersCRUD : Form
    {
        public ComMembersCRUD(string str)
        {
            InitializeComponent();

            if (str == "dlt")
            {
                label1.Visible = false;
                panel1.Visible = false;




                label2.Visible = true;
                button2.Visible = true;
            }
            if (str == "update")
            {
                label2.Visible  = false;
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
            
        }
    }
}
