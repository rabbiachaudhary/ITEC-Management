namespace dbmid_project
{
    partial class ReportsUI
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
            label3 = new Label();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            Participant = new ColumnHeader();
            Event = new ColumnHeader();
            Payment = new ColumnHeader();
            Role = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            listView4 = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            listView5 = new ListView();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-14, -4);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 7;
            label1.Text = "Generate Reports";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 112);
            label3.MinimumSize = new Size(200, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 0, 0, 0);
            label3.Size = new Size(239, 31);
            label3.TabIndex = 20;
            label3.Text = "Select Report Type:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Auditorium", "Classrooms", "Open Areas" });
            comboBox2.Location = new Point(477, 107);
            comboBox2.MaximumSize = new Size(250, 0);
            comboBox2.MinimumSize = new Size(250, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 36);
            comboBox2.TabIndex = 21;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Participant, Event, Payment, Role });
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(91, 206);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(803, 630);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Participant
            // 
            Participant.Text = "Participant";
            Participant.Width = 200;
            // 
            // Event
            // 
            Event.Text = "Event";
            Event.TextAlign = HorizontalAlignment.Center;
            Event.Width = 200;
            // 
            // Payment
            // 
            Payment.Text = "Payment";
            Payment.TextAlign = HorizontalAlignment.Center;
            Payment.Width = 200;
            // 
            // Role
            // 
            Role.Text = "Role";
            Role.TextAlign = HorizontalAlignment.Center;
            Role.Width = 200;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(685, 884);
            button1.Name = "button1";
            button1.Size = new Size(209, 51);
            button1.TabIndex = 23;
            button1.Text = "Print Report";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(389, 884);
            button2.Name = "button2";
            button2.Size = new Size(209, 51);
            button2.TabIndex = 24;
            button2.Text = "Load Reports";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(91, 884);
            button3.Name = "button3";
            button3.Size = new Size(209, 51);
            button3.TabIndex = 25;
            button3.Text = "Export To Pdf";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5 });
            listView2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView2.FullRowSelect = true;
            listView2.Location = new Point(105, 206);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(780, 630);
            listView2.TabIndex = 26;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Event";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Venue";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Assigned Date And Time";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 280;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView3.FullRowSelect = true;
            listView3.Location = new Point(45, 206);
            listView3.MultiSelect = false;
            listView3.Name = "listView3";
            listView3.Size = new Size(893, 630);
            listView3.TabIndex = 27;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Event";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Category";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Description";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Event Date";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Venue";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Committee";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 120;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView4.FullRowSelect = true;
            listView4.Location = new Point(56, 206);
            listView4.MultiSelect = false;
            listView4.Name = "listView4";
            listView4.Size = new Size(867, 630);
            listView4.TabIndex = 28;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Committee Name";
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Assigned To";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Task Description";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 220;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Deadline";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Value";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            columnHeader14.Width = 150;
            // 
            // listView5
            // 
            listView5.Columns.AddRange(new ColumnHeader[] { columnHeader15, columnHeader16, columnHeader17, columnHeader18, columnHeader19, columnHeader20, columnHeader21 });
            listView5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView5.FullRowSelect = true;
            listView5.Location = new Point(36, 206);
            listView5.MultiSelect = false;
            listView5.Name = "listView5";
            listView5.Size = new Size(927, 630);
            listView5.TabIndex = 29;
            listView5.UseCompatibleStateImageBehavior = false;
            listView5.View = View.Details;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Event";
            columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Finance Type";
            columnHeader16.TextAlign = HorizontalAlignment.Center;
            columnHeader16.Width = 130;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Amount";
            columnHeader17.TextAlign = HorizontalAlignment.Center;
            columnHeader17.Width = 120;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "From ";
            columnHeader18.TextAlign = HorizontalAlignment.Center;
            columnHeader18.Width = 120;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "To";
            columnHeader19.TextAlign = HorizontalAlignment.Center;
            columnHeader19.Width = 120;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Description";
            columnHeader20.TextAlign = HorizontalAlignment.Center;
            columnHeader20.Width = 160;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Date and Time";
            columnHeader21.TextAlign = HorizontalAlignment.Center;
            columnHeader21.Width = 150;
            // 
            // ReportsUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(listView5);
            Controls.Add(listView4);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ReportsUI";
            Text = "ReportsUI";
            Load += ReportsUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox comboBox2;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader Participant;
        private ColumnHeader Event;
        private ColumnHeader Payment;
        private ColumnHeader Role;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader5;
        private ListView listView3;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ListView listView4;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ListView listView5;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
    }
}