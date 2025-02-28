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
    public partial class Addevent : Form
    {
        public Addevent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminDashboard mainForm = (AdminDashboard)this.ParentForm;
            mainForm.OpenFormInPanel(new ParticpantDetails());   
        }
    }
}
