namespace dbmid_project
{
    partial class AddDuties
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
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            comboBox3 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-9, 0);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 5;
            label1.Text = "Add Duties";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(215, 118);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(561, 727);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Auditorium", "Classrooms", "Open Areas" });
            comboBox2.Location = new Point(151, 48);
            comboBox2.MaximumSize = new Size(250, 0);
            comboBox2.MinimumSize = new Size(250, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 36);
            comboBox2.TabIndex = 25;
            // 
            // monthCalendar1
            // 
            monthCalendar1.AllowDrop = true;
            monthCalendar1.Location = new Point(151, 402);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(151, 223);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 136);
            textBox2.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(174, 189);
            label6.MinimumSize = new Size(200, 30);
            label6.Name = "label6";
            label6.Padding = new Padding(20, 0, 0, 0);
            label6.Size = new Size(200, 31);
            label6.TabIndex = 23;
            label6.Text = "Description:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(174, 373);
            label5.MinimumSize = new Size(200, 30);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 0, 0, 0);
            label5.Size = new Size(200, 31);
            label5.TabIndex = 22;
            label5.Text = "Deadline:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auditorium", "Classrooms", "Open Areas" });
            comboBox1.Location = new Point(151, 135);
            comboBox1.MaximumSize = new Size(250, 0);
            comboBox1.MinimumSize = new Size(250, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 36);
            comboBox1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(159, 101);
            label4.MinimumSize = new Size(200, 30);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(226, 31);
            label4.TabIndex = 20;
            label4.Text = "Duty Assigned To:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 14);
            label2.MinimumSize = new Size(200, 30);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(234, 31);
            label2.TabIndex = 1;
            label2.Text = "Committee Name :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(389, 888);
            button1.Name = "button1";
            button1.Size = new Size(209, 51);
            button1.TabIndex = 20;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(174, 618);
            label3.MinimumSize = new Size(200, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 0, 0, 0);
            label3.Size = new Size(200, 31);
            label3.TabIndex = 26;
            label3.Text = "Status:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            comboBox3.AllowDrop = true;
            comboBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pending", "In Progress", "Completed" });
            comboBox3.Location = new Point(151, 658);
            comboBox3.MaximumSize = new Size(250, 0);
            comboBox3.MinimumSize = new Size(250, 0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 36);
            comboBox3.TabIndex = 27;
            // 
            // AddDuties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AddDuties";
            Text = "AddDuties";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private Label label2;
        private TextBox textBox2;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label3;
    }
}