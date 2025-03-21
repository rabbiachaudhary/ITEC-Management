namespace dbmid_project
{
    partial class Sponsors
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
            button3 = new Button();
            button1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
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
            label1.Location = new Point(-16, -2);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 5;
            label1.Text = "Sponsors";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { mname, role });
            listView1.Location = new Point(283, 116);
            listView1.Name = "listView1";
            listView1.Size = new Size(405, 265);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // mname
            // 
            mname.Text = "Sponsor";
            mname.Width = 200;
            // 
            // role
            // 
            role.Text = "Contact";
            role.TextAlign = HorizontalAlignment.Center;
            role.Width = 200;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(283, 405);
            button3.Name = "button3";
            button3.Size = new Size(174, 51);
            button3.TabIndex = 23;
            button3.Text = "Update ";
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
            button1.Location = new Point(514, 405);
            button1.Name = "button1";
            button1.Size = new Size(174, 51);
            button1.TabIndex = 24;
            button1.Text = "Delete ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-16, 496);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.MinimumSize = new Size(1002, 70);
            label2.Name = "label2";
            label2.Size = new Size(1002, 70);
            label2.TabIndex = 25;
            label2.Text = "Add Sponsors";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(196, 613);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(561, 406);
            panel1.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(155, 185);
            textBox2.MaximumSize = new Size(250, 40);
            textBox2.MinimumSize = new Size(250, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 34);
            textBox2.TabIndex = 23;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(176, 286);
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
            label3.Location = new Point(176, 151);
            label3.MinimumSize = new Size(200, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 0, 0, 0);
            label3.Size = new Size(200, 31);
            label3.TabIndex = 19;
            label3.Text = "Contact:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 42);
            label4.MinimumSize = new Size(200, 30);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(203, 31);
            label4.TabIndex = 1;
            label4.Text = "Sponsor Name :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(152, 87);
            textBox1.MaximumSize = new Size(250, 40);
            textBox1.MinimumSize = new Size(250, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 10;
            // 
            // Sponsors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Sponsors";
            Text = "Sponsors";
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
        private Button button3;
        private Button button1;
        private Label label2;
        private Panel panel1;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
    }
}