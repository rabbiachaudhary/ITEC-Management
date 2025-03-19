namespace dbmid_project
{
    partial class Registration
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
            textBox1 = new TextBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-11, -2);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 1;
            label1.Text = "Manage Event Registration";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(212, 140);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(561, 616);
            panel1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(157, 348);
            textBox1.MaximumSize = new Size(250, 40);
            textBox1.MinimumSize = new Size(250, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 23;
            // 
            // comboBox3
            // 
            comboBox3.AllowDrop = true;
            comboBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pending", "Paid", "Canceled" });
            comboBox3.Location = new Point(157, 466);
            comboBox3.MaximumSize = new Size(250, 0);
            comboBox3.MinimumSize = new Size(250, 0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 36);
            comboBox3.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 413);
            label3.MinimumSize = new Size(200, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 0, 0, 0);
            label3.Size = new Size(211, 31);
            label3.TabIndex = 21;
            label3.Text = "Payment Status :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "b" });
            comboBox1.Location = new Point(157, 224);
            comboBox1.MaximumSize = new Size(250, 0);
            comboBox1.MinimumSize = new Size(250, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 36);
            comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(177, 181);
            label5.MinimumSize = new Size(200, 30);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 0, 0, 0);
            label5.Size = new Size(200, 31);
            label5.TabIndex = 19;
            label5.Text = "Event Name :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 71);
            label2.MinimumSize = new Size(200, 30);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(200, 31);
            label2.TabIndex = 1;
            label2.Text = "Participant:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "b" });
            comboBox2.Location = new Point(157, 118);
            comboBox2.MaximumSize = new Size(250, 0);
            comboBox2.MinimumSize = new Size(250, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 36);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 297);
            label4.MinimumSize = new Size(200, 30);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(200, 31);
            label4.TabIndex = 8;
            label4.Text = "Fee Amount:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(389, 809);
            button1.Name = "button1";
            button1.Size = new Size(209, 51);
            button1.TabIndex = 19;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Registration";
            Text = "RegTypesNDFees";
            Load += Registration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label3;
        private ComboBox comboBox3;
        private TextBox textBox1;
    }
}