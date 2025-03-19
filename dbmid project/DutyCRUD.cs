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
    public partial class DutyCRUD : Form
    {
        public DutyCRUD(string str)
        {
            InitializeComponent();
            if (str == "dlt")
            {
                label1.Visible = false;

            }
        }

        private void DutyCRUD_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
