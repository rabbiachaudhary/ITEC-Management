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
            listView1.Location = new Point(269, 130);
            listView1.Name = "listView1";
            listView1.Size = new Size(405, 265);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(201, 623);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(561, 446);
            panel1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 178);
            label3.MinimumSize = new Size(200, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 0, 0, 0);
            label3.Size = new Size(200, 31);
            label3.TabIndex = 19;
            label3.Text = "Role:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "FacultyAdvisor", "Student Lead", "Volunteer" });
            comboBox2.Location = new Point(147, 229);
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
            label4.Location = new Point(163, 65);
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
            textBox1.Location = new Point(147, 116);
            textBox1.MaximumSize = new Size(250, 40);
            textBox1.MinimumSize = new Size(250, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 10;
            // 
            // MemberinCom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "MemberinCom";
            Text = "MemberinCom";
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
    }
}