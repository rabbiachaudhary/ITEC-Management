namespace dbmid_project
{
    partial class Venues
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
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            panel2.SuspendLayout();
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
            label1.TabIndex = 2;
            label1.Text = "Venues";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { mname, cap, Location });
            listView1.Location = new Point(236, 128);
            listView1.Name = "listView1";
            listView1.Size = new Size(503, 274);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // mname
            // 
            mname.Text = "Name";
            mname.Width = 200;
            // 
            // cap
            // 
            cap.Text = "Capacity";
            cap.TextAlign = HorizontalAlignment.Center;
            cap.Width = 150;
            // 
            // Location
            // 
            Location.Text = "Location";
            Location.TextAlign = HorizontalAlignment.Center;
            Location.Width = 150;
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
            label2.TabIndex = 7;
            label2.Text = "Add Venues";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(220, 566);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(30);
            panel2.Size = new Size(551, 433);
            panel2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(167, 220);
            label3.MinimumSize = new Size(200, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 0, 0, 0);
            label3.Size = new Size(200, 31);
            label3.TabIndex = 23;
            label3.Text = "Location:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(147, 157);
            textBox3.MaximumSize = new Size(250, 40);
            textBox3.MinimumSize = new Size(250, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 34);
            textBox3.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(147, 254);
            textBox1.MaximumSize = new Size(250, 40);
            textBox1.MinimumSize = new Size(250, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(167, 327);
            button1.Name = "button1";
            button1.Size = new Size(209, 51);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(167, 123);
            label5.MinimumSize = new Size(200, 30);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 0, 0, 0);
            label5.Size = new Size(200, 31);
            label5.TabIndex = 19;
            label5.Text = "Capacity:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(167, 30);
            label6.MinimumSize = new Size(200, 30);
            label6.Name = "label6";
            label6.Padding = new Padding(20, 0, 0, 0);
            label6.Size = new Size(200, 31);
            label6.TabIndex = 1;
            label6.Text = "Venue :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(147, 64);
            textBox2.MaximumSize = new Size(250, 40);
            textBox2.MinimumSize = new Size(250, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 34);
            textBox2.TabIndex = 10;
            // 
            // Venues
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Venues";
            Text = "Venues";
            Load += Venues_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader mname;
        private ColumnHeader cap;
        private ColumnHeader Location;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
    }
}