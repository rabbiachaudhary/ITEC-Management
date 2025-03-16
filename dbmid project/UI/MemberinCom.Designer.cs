namespace dbmid_project
{
    partial class MemberinCom
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
            role = new ColumnHeader();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-8, -3);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 3;
            label1.Text = "Members";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { mname, role });
            listView1.Location = new Point(277, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(405, 265);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // mname
            // 
            mname.Text = "Name";
            mname.Width = 200;
            // 
            // role
            // 
            role.Text = "Role";
            role.TextAlign = HorizontalAlignment.Center;
            role.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-9, 463);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.MinimumSize = new Size(1002, 70);
            label2.Name = "label2";
            label2.Size = new Size(1002, 70);
            label2.TabIndex = 5;
            label2.Text = "Add Members";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(201, 599);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(561, 470);
            panel1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(172, 217);
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
            comboBox1.Location = new Point(147, 163);
            comboBox1.MaximumSize = new Size(250, 0);
            comboBox1.MinimumSize = new Size(250, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 36);
            comboBox1.TabIndex = 21;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(167, 327);
            button2.Name = "button2";
            button2.Size = new Size(209, 51);
            button2.TabIndex = 20;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 129);
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
            comboBox2.Location = new Point(147, 251);
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
            label4.Location = new Point(167, 30);
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
            textBox1.Location = new Point(147, 77);
            textBox1.MaximumSize = new Size(250, 40);
            textBox1.MinimumSize = new Size(250, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 10;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(277, 393);
            button3.Name = "button3";
            button3.Size = new Size(174, 51);
            button3.TabIndex = 21;
            button3.Text = "Update a Member";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(508, 393);
            button1.Name = "button1";
            button1.Size = new Size(174, 51);
            button1.TabIndex = 22;
            button1.Text = "Delete a member";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // MemberinCom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "MemberinCom";
            Text = "MemberinCom";
            Load += MemberinCom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader mname;
        private ColumnHeader role;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button1;
        private Label label5;
        private ComboBox comboBox1;
    }
}