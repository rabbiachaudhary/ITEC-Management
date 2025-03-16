namespace dbmid_project
{
    partial class ComMembersCRUD
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
            label2 = new Label();
            label9 = new Label();
            comboBox5 = new ComboBox();
            button2 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-9, -7);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 1;
            label1.Text = "Update Member ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-9, -7);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.MinimumSize = new Size(1002, 70);
            label2.Name = "label2";
            label2.Size = new Size(1002, 70);
            label2.TabIndex = 2;
            label2.Text = "Delete Member";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(388, 103);
            label9.MinimumSize = new Size(200, 30);
            label9.Name = "label9";
            label9.Padding = new Padding(20, 0, 0, 0);
            label9.Size = new Size(205, 31);
            label9.TabIndex = 19;
            label9.Text = "Member Name :";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox5
            // 
            comboBox5.AllowDrop = true;
            comboBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(359, 149);
            comboBox5.MaximumSize = new Size(250, 0);
            comboBox5.MinimumSize = new Size(250, 0);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(250, 36);
            comboBox5.TabIndex = 20;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(384, 206);
            button2.Name = "button2";
            button2.Size = new Size(209, 51);
            button2.TabIndex = 21;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(212, 263);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(561, 470);
            panel1.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(176, 217);
            label5.MinimumSize = new Size(200, 30);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 0, 0, 0);
            label5.Size = new Size(200, 31);
            label5.TabIndex = 22;
            label5.Text = "Role:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 161);
            comboBox1.MaximumSize = new Size(250, 0);
            comboBox1.MinimumSize = new Size(250, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 36);
            comboBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(166, 348);
            button1.Name = "button1";
            button1.Size = new Size(209, 51);
            button1.TabIndex = 20;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 116);
            label3.MinimumSize = new Size(200, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 0, 0, 0);
            label3.Size = new Size(200, 31);
            label3.TabIndex = 19;
            label3.Text = "Committee:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(147, 260);
            comboBox2.MaximumSize = new Size(250, 0);
            comboBox2.MinimumSize = new Size(250, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 36);
            comboBox2.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 19);
            label4.MinimumSize = new Size(200, 30);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(205, 31);
            label4.TabIndex = 1;
            label4.Text = "Member Name :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(147, 64);
            textBox1.MaximumSize = new Size(250, 40);
            textBox1.MinimumSize = new Size(250, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 10;
            // 
            // ComMembersCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(comboBox5);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ComMembersCRUD";
            Text = "ComMembersCRUD";
            Load += ComMembersCRUD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label9;
        private ComboBox comboBox5;
        private Button button2;
        private Panel panel1;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox1;
    }
}