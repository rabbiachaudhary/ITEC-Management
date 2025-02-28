namespace dbmid_project
{
    partial class AddCommittee
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
            label3 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-14, -5);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 2;
            label1.Text = "Add Committees";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(212, 140);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(561, 533);
            panel1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 182);
            label3.MinimumSize = new Size(200, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 0, 0, 0);
            label3.Size = new Size(200, 31);
            label3.TabIndex = 19;
            label3.Text = "Event:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Auditorium", "Classrooms", "Open Areas" });
            comboBox2.Location = new Point(147, 229);
            comboBox2.MaximumSize = new Size(250, 0);
            comboBox2.MinimumSize = new Size(250, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 36);
            comboBox2.TabIndex = 18;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(49, 328);
            button2.Name = "button2";
            button2.Size = new Size(209, 51);
            button2.TabIndex = 17;
            button2.Text = "Add Members";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(302, 328);
            button1.Name = "button1";
            button1.Size = new Size(209, 51);
            button1.TabIndex = 16;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 63);
            label2.MinimumSize = new Size(200, 30);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(234, 31);
            label2.TabIndex = 1;
            label2.Text = "Committee Name :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(147, 116);
            textBox1.MaximumSize = new Size(250, 40);
            textBox1.MinimumSize = new Size(250, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 10;
            // 
            // AddCommittee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AddCommittee";
            Text = "AddCommittee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label3;
        private ComboBox comboBox2;
    }
}