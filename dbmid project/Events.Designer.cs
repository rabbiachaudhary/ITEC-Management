namespace dbmid_project
{
    partial class Events
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
            ListViewItem listViewItem2 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            listView1 = new ListView();
            Event = new ColumnHeader();
            date = new ColumnHeader();
            Venue = new ColumnHeader();
            Action = new ColumnHeader();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            viewDetailsToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Event, date, Venue, Action });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.FullRowSelect = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(53, 212);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(868, 732);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Event
            // 
            Event.Text = "Event";
            Event.Width = 250;
            // 
            // date
            // 
            date.Text = "Date";
            date.TextAlign = HorizontalAlignment.Center;
            date.Width = 250;
            // 
            // Venue
            // 
            Venue.Text = "Venue";
            Venue.TextAlign = HorizontalAlignment.Center;
            Venue.Width = 250;
            // 
            // Action
            // 
            Action.Text = "Actions";
            Action.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-10, -1);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 2;
            label1.Text = "Events";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By Event Name";
            textBox1.Size = new Size(563, 51);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // viewDetailsToolStripMenuItem
            // 
            viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            viewDetailsToolStripMenuItem.Size = new Size(210, 24);
            viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(210, 24);
            updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(210, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewDetailsToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 76);
            // 
            // Events
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Events";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Event;
        private ColumnHeader date;
        private ColumnHeader Venue;
        private ColumnHeader Action;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewDetailsToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}