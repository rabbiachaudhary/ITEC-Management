namespace dbmid_project
{
    partial class Duties
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duties));
            label1 = new Label();
            listView1 = new ListView();
            cname = new ColumnHeader();
            Event = new ColumnHeader();
            Deadine = new ColumnHeader();
            status = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            viewDetailsToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, 0);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 4;
            label1.Text = "Duties";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { cname, Event, Deadine, status });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.FullRowSelect = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(121, 209);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(766, 485);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // cname
            // 
            cname.Text = "Committee Name";
            cname.Width = 190;
            // 
            // Event
            // 
            Event.Text = "Assigned to";
            Event.TextAlign = HorizontalAlignment.Center;
            Event.Width = 190;
            // 
            // Deadine
            // 
            Deadine.DisplayIndex = 3;
            Deadine.Text = "Deadlline";
            Deadine.TextAlign = HorizontalAlignment.Center;
            Deadine.Width = 190;
            // 
            // status
            // 
            status.DisplayIndex = 2;
            status.Text = "Status";
            status.TextAlign = HorizontalAlignment.Center;
            status.Width = 190;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewDetailsToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(153, 76);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // viewDetailsToolStripMenuItem
            // 
            viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            viewDetailsToolStripMenuItem.Size = new Size(152, 24);
            viewDetailsToolStripMenuItem.Text = "Pending";
            viewDetailsToolStripMenuItem.Click += viewDetailsToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(152, 24);
            updateToolStripMenuItem.Text = "In Progress";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(152, 24);
            deleteToolStripMenuItem.Text = "Completed";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By Events";
            textBox1.Size = new Size(359, 51);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(444, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(763, 111);
            button1.Name = "button1";
            button1.Size = new Size(124, 51);
            button1.TabIndex = 8;
            button1.Text = "Update A Duty";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(622, 111);
            button2.Name = "button2";
            button2.Size = new Size(124, 51);
            button2.TabIndex = 9;
            button2.Text = "Delete A Duty";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Duties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Duties";
            Text = "Duties";
            Load += Duties_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader cname;
        private ColumnHeader Event;
        private ColumnHeader Deadine;
        private ColumnHeader status;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewDetailsToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button button1;
        private Button button2;
    }
}