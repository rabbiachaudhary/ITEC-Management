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

            string name=textBox1.Text;
            string venue = comboBox2.SelectedItem.ToString();
            string category = comboBox1.SelectedItem.ToString();
            DateTime date = monthCalendar1.SelectionStart;
            string description = textBox2.Text;

        }

        private void Addevent_Load(object sender, EventArgs e)
        {

        }
    }
}
