using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbmid_project.DL;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace dbmid_project
{
    public partial class ReportsUI : Form
    {
        public ReportsUI()
        {
            InitializeComponent();
            listView1.Visible = false;
            listView2.Visible = false;
            listView3.Visible = false;
            listView5.Visible = false;
            listView4.Visible = false;

            this.Load += ReportsUI_Load;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintListView);
            PrintDialog printDialog = new PrintDialog
            {
                Document = pd
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected = comboBox2.SelectedItem.ToString();

            if (selected == "Participants Reports")
            {
                listView1.Visible = true;

                DataTable d = ReportsDL.Getreport(selected);
                listView1.Items.Clear();
                foreach (DataRow row in d.Rows)
                {
                    ListViewItem item = new ListViewItem(row["name"].ToString());

                    item.SubItems.Add(row["event_name"].ToString());
                    item.SubItems.Add(row["value"].ToString());
                    item.SubItems.Add(row["role_name"].ToString());
                    listView1.Items.Add(item);

                }
            }
            if (selected == "Venue Allocations")
            {
                listView2.Visible = true;

                DataTable d = ReportsDL.Getreport(selected);
                listView2.Items.Clear();
                foreach (DataRow row in d.Rows)
                {
                    ListViewItem item = new ListViewItem(row["event_name"].ToString());

                    item.SubItems.Add(row["venue_name"].ToString());
                    item.SubItems.Add(row["assigned_date"].ToString());
                    listView2.Items.Add(item);

                }
            }

            if (selected == "Event Schedule Reports")
            {
                listView3.Visible = true;

                DataTable d = ReportsDL.Getreport(selected);
                listView3.Items.Clear();
                foreach (DataRow row in d.Rows)
                {
                    ListViewItem item = new ListViewItem(row["event_name"].ToString());

                    item.SubItems.Add(row["category_name"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["event_date"].ToString());
                    item.SubItems.Add(row["venue_name"].ToString());
                    item.SubItems.Add(row["committee_name"].ToString());

                    listView3.Items.Add(item);

                }
            }


            if (selected == "Committee Assignment Reports")
            {
                listView4.Visible = true;

                DataTable d = ReportsDL.Getreport(selected);
                listView4.Items.Clear();
                foreach (DataRow row in d.Rows)
                {
                    ListViewItem item = new ListViewItem(row["committee_name"].ToString());

                    item.SubItems.Add(row["assigned_to"].ToString());
                    item.SubItems.Add(row["task_description"].ToString());
                    item.SubItems.Add(row["deadline"].ToString());
                    item.SubItems.Add(row["value"].ToString());

                    listView4.Items.Add(item);

                }
            }

            if (selected == "Financial Reports")
            {
                listView5.Visible = true;

                DataTable d = ReportsDL.Getreport(selected);
                listView5.Items.Clear();
                foreach (DataRow row in d.Rows)
                {
                    ListViewItem item = new ListViewItem(row["event_name"].ToString());

                    item.SubItems.Add(row["value"].ToString());
                    item.SubItems.Add(row["amount"].ToString());
                    item.SubItems.Add(row["from_entity_type"].ToString());
                    item.SubItems.Add(row["to_entity_type"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["date_recorded"].ToString());


                    listView5.Items.Add(item);

                }
            }

            ReportsUI_Load(sender, e);

        }



        private void ReportsUI_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Participants Reports");
            comboBox2.Items.Add("Venue Allocations");
            comboBox2.Items.Add("Event Schedule Reports");
            comboBox2.Items.Add("Committee Assignment Reports");
            comboBox2.Items.Add("Financial Reports");
        }

        private void button3_Click(object sender, EventArgs e)
        {




            if (comboBox2.SelectedItem.ToString() == "Financial Reports")
            {
                if (listView5.Items.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF Files|*.pdf";
                    sfd.FileName = "Report.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        PdfPTable table = new PdfPTable(listView5.Columns.Count);

                        // Adding column headers
                        foreach (ColumnHeader col in listView5.Columns)
                        {
                            table.AddCell(new Phrase(col.Text));
                        }

                        // Adding row data
                        foreach (ListViewItem item in listView5.Items)
                        {
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                table.AddCell(subItem.Text);
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                        MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }




            if (comboBox2.SelectedItem.ToString() == "Committee Assignment Reports")
            {
                if (listView4.Items.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF Files|*.pdf";
                    sfd.FileName = "Report.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        PdfPTable table = new PdfPTable(listView4.Columns.Count);

                        // Adding column headers
                        foreach (ColumnHeader col in listView4.Columns)
                        {
                            table.AddCell(new Phrase(col.Text));
                        }

                        // Adding row data
                        foreach (ListViewItem item in listView4.Items)
                        {
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                table.AddCell(subItem.Text);
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                        MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }





            if (comboBox2.SelectedItem.ToString() == "Event Schedule Reports")
            {
                if (listView3.Items.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF Files|*.pdf";
                    sfd.FileName = "Report.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        PdfPTable table = new PdfPTable(listView3.Columns.Count);

                        // Adding column headers
                        foreach (ColumnHeader col in listView3.Columns)
                        {
                            table.AddCell(new Phrase(col.Text));
                        }

                        // Adding row data
                        foreach (ListViewItem item in listView3.Items)
                        {
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                table.AddCell(subItem.Text);
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                        MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }




            if (comboBox2.SelectedItem.ToString() == "Venue Allocations")
            {
                if (listView2.Items.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF Files|*.pdf";
                    sfd.FileName = "Report.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        PdfPTable table = new PdfPTable(listView2.Columns.Count);

                        // Adding column headers
                        foreach (ColumnHeader col in listView2.Columns)
                        {
                            table.AddCell(new Phrase(col.Text));
                        }

                        // Adding row data
                        foreach (ListViewItem item in listView2.Items)
                        {
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                table.AddCell(subItem.Text);
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                        MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



            if (comboBox2.SelectedItem.ToString() == "Participants Reports")
            {
                if (listView1.Items.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF Files|*.pdf";
                    sfd.FileName = "Report.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        PdfPTable table = new PdfPTable(listView1.Columns.Count);

                        // Adding column headers
                        foreach (ColumnHeader col in listView1.Columns)
                        {
                            table.AddCell(new Phrase(col.Text));
                        }

                        // Adding row data
                        foreach (ListViewItem item in listView1.Items)
                        {
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                table.AddCell(subItem.Text);
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                        MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void PrintListView(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(listView1.Width, listView1.Height);

            // Explicitly specify System.Drawing.Rectangle to avoid ambiguity
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, listView1.Width, listView1.Height);

            listView1.DrawToBitmap(bm, rect);
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
