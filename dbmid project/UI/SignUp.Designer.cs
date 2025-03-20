namespace dbmid_project
{
    partial class SignUp
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
            label6 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(418, 57);
            label6.Name = "label6";
            label6.Size = new Size(530, 46);
            label6.TabIndex = 3;
            label6.Text = "ITEC Event Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(275, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 525);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Faculty" });
            comboBox1.Location = new Point(87, 393);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(288, 28);
            comboBox1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(459, 310);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 24;
            label4.Text = "Already have an account? ";
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(474, 229);
            button1.Name = "button1";
            button1.Size = new Size(209, 51);
            button1.TabIndex = 23;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Signup_Button;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(637, 310);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LogIn";
            linkLabel1.VisitedLinkColor = Color.FromArgb(0, 0, 64);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(87, 189);
            textBox10.MaximumSize = new Size(500, 70);
            textBox10.MinimumSize = new Size(150, 35);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Email address";
            textBox10.Size = new Size(288, 35);
            textBox10.TabIndex = 19;
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(87, 261);
            textBox9.MaximumSize = new Size(500, 70);
            textBox9.MinimumSize = new Size(150, 35);
            textBox9.Name = "textBox9";
            textBox9.PasswordChar = '*';
            textBox9.PlaceholderText = "Password";
            textBox9.Size = new Size(288, 35);
            textBox9.TabIndex = 18;
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.UseSystemPasswordChar = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(87, 327);
            textBox8.MaximumSize = new Size(500, 70);
            textBox8.MinimumSize = new Size(150, 35);
            textBox8.Name = "textBox8";
            textBox8.PasswordChar = '*';
            textBox8.PlaceholderText = "Confirm Password";
            textBox8.Size = new Size(288, 35);
            textBox8.TabIndex = 17;
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox8.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(87, 121);
            textBox4.MaximumSize = new Size(700, 70);
            textBox4.MinimumSize = new Size(150, 35);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Name";
            textBox4.Size = new Size(288, 35);
            textBox4.TabIndex = 13;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(87, 40);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 9;
            label3.Text = "Sign Up";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1353, 747);
            Controls.Add(panel1);
            Controls.Add(label6);
            Name = "SignUp";
            Text = "Form2";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label4;
        private ComboBox comboBox1;
    }
}