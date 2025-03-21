namespace dbmid_project
{
    partial class TrackFees
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
            label1 = new Label();
            listView1 = new ListView();
            cname = new ColumnHeader();
            Event = new ColumnHeader();
            Amount = new ColumnHeader();
            Status = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            viewDetailsToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
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
            label1.TabIndex = 7;
            label1.Text = "Track Registration Fees";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { cname, Event, Amount, Status });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.FullRowSelect = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(98, 115);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(766, 485);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // cname
            // 
            cname.Text = "Event Name";
            cname.Width = 190;
            // 
            // Event
            // 
            Event.Text = "Participant Name";
            Event.TextAlign = HorizontalAlignment.Center;
            Event.Width = 190;
            // 
            // Amount
            // 
            Amount.Text = "Amount";
            Amount.TextAlign = HorizontalAlignment.Center;
            Amount.Width = 200;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.TextAlign = HorizontalAlignment.Center;
            Status.Width = 200;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewDetailsToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 104);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // viewDetailsToolStripMenuItem
            // 
            viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            viewDetailsToolStripMenuItem.Size = new Size(210, 24);
            viewDetailsToolStripMenuItem.Text = "Pending";
            viewDetailsToolStripMenuItem.Click += viewDetailsToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(210, 24);
            updateToolStripMenuItem.Text = "Paid";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(210, 24);
            deleteToolStripMenuItem.Text = "Canceled";
            // 
            // TrackFees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "TrackFees";
            Text = "TrackFees";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader cname;
        private ColumnHeader Event;
        private ColumnHeader Amount;
        private ColumnHeader Status;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewDetailsToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}