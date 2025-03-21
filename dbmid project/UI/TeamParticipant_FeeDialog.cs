using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbmid_project.DL;

namespace dbmid_project
{
    public partial class TeamParticipant_FeeDialog : Form
    {
        public TeamParticipant_FeeDialog()
        {
            InitializeComponent();
        }

        private void TeamParticipant_FeeDialog_Load(object sender, EventArgs e)
        {

        }
        public void SetParticipantName(string name)
        {
            label3.Text = name; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || !float.TryParse(textBox1.Text, out float amount))
                {
                    MessageBox.Show("Please enter a valid fee amount.");
                    return;
                }

                if (comboBox3.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment status.");
                    return;
                }

                string feestatus = comboBox3.SelectedItem.ToString();
                string name = label3.Text;

                teamsDL.AddFee(feestatus, amount, name);
                MessageBox.Show("Fee added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
s