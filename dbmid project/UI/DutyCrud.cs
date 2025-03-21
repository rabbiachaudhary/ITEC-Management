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
    public partial class DutyCrud : Form
    {
        public DutyCrud(string str)
        {
            InitializeComponent();


            if (str == "dlt")
            {
                label2.Visible = false;
            }

            if (str == "update")
            {
                label1.Visible = false;
            }
        }

        private void DutyCrud_Load(object sender, EventArgs e)
        {

        }
    }
}
