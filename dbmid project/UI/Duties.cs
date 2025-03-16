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
    public partial class Duties : Form
    {
        public Duties()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new DutyCRUD("dlt"));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminDashboard a = (AdminDashboard)this.ParentForm;
            a.OpenFormInPanel(new DutyCRUD("update"));
        }
    }
}
