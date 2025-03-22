namespace dbmid_project
{
    partial class Results
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listView1 = new ListView();
            mname = new ColumnHeader();
            cap = new ColumnHeader();
            Location = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-12, -4);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 3;
            label1.Text = "LeaderBoard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { mname, cap, Location, columnHeader1, columnHeader2 });
            listView1.Location = new Point(57, 131);
            listView1.Name = "listView1";
            listView1.Size = new Size(856, 599);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // mname
            // 
            mname.Text = "Event";
            mname.Width = 150;
            // 
            // cap
            // 
            cap.Text = "Participant";
            cap.TextAlign = HorizontalAlignment.Center;
            cap.Width = 200;
            // 
            // Location
            // 
            Location.Text = "Position";
            Location.TextAlign = HorizontalAlignment.Center;
            Location.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Score";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Remarks";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Results";
            Text = "RecordResults";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader mname;
        private ColumnHeader cap;
        private ColumnHeader Location;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}