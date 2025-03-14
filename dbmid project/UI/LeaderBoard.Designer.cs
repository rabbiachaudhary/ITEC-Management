namespace dbmid_project
{
    partial class LeaderBoard
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
            dataGridView1 = new DataGridView();
            Position = new DataGridViewTextBoxColumn();
            ParticipantName = new DataGridViewTextBoxColumn();
            Event = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-12, -2);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.MinimumSize = new Size(1002, 70);
            label1.Name = "label1";
            label1.Size = new Size(1002, 70);
            label1.TabIndex = 7;
            label1.Text = "Leaderboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Position, ParticipantName, Event, Score, Remarks });
            dataGridView1.Location = new Point(54, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(860, 648);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 170;
            // 
            // ParticipantName
            // 
            ParticipantName.HeaderText = "Participant Name";
            ParticipantName.MinimumWidth = 6;
            ParticipantName.Name = "ParticipantName";
            ParticipantName.ReadOnly = true;
            ParticipantName.Width = 170;
            // 
            // Event
            // 
            Event.HeaderText = "Event";
            Event.MinimumWidth = 6;
            Event.Name = "Event";
            Event.ReadOnly = true;
            Event.Width = 170;
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.MinimumWidth = 6;
            Score.Name = "Score";
            Score.ReadOnly = true;
            Score.Width = 125;
            // 
            // Remarks
            // 
            Remarks.HeaderText = "Remarks";
            Remarks.MinimumWidth = 6;
            Remarks.Name = "Remarks";
            Remarks.ReadOnly = true;
            Remarks.Width = 170;
            // 
            // LeaderBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 997);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "LeaderBoard";
            Text = "LeaderBoard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn ParticipantName;
        private DataGridViewTextBoxColumn Event;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn Remarks;
    }
}