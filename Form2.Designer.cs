namespace BookBag
{
    partial class SortingWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortingWindow));
            this.UnsortedList = new System.Windows.Forms.ListBox();
            this.RandomItemsBox = new System.Windows.Forms.GroupBox();
            this.SortedBox = new System.Windows.Forms.GroupBox();
            this.SortedList = new System.Windows.Forms.ListBox();
            this.ItemUpButton = new System.Windows.Forms.Button();
            this.ItemDownButton = new System.Windows.Forms.Button();
            this.SortControlBox = new System.Windows.Forms.GroupBox();
            this.InstructionBox = new System.Windows.Forms.GroupBox();
            this.InstructionLableOne = new System.Windows.Forms.Label();
            this.FinishBox = new System.Windows.Forms.GroupBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.GroupBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UserTimer = new System.Windows.Forms.Timer(this.components);
            this.DatabaseBox = new System.Windows.Forms.GroupBox();
            this.DatabaseTimeLabel = new System.Windows.Forms.Label();
            this.EasyButton = new System.Windows.Forms.RadioButton();
            this.DiffcultyBox = new System.Windows.Forms.GroupBox();
            this.HardButton = new System.Windows.Forms.RadioButton();
            this.MediumButton = new System.Windows.Forms.RadioButton();
            this.ClearBox = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RandomItemsBox.SuspendLayout();
            this.SortedBox.SuspendLayout();
            this.SortControlBox.SuspendLayout();
            this.InstructionBox.SuspendLayout();
            this.FinishBox.SuspendLayout();
            this.ScoreBox.SuspendLayout();
            this.TimeBox.SuspendLayout();
            this.DatabaseBox.SuspendLayout();
            this.DiffcultyBox.SuspendLayout();
            this.ClearBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnsortedList
            // 
            this.UnsortedList.AllowDrop = true;
            this.UnsortedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnsortedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnsortedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnsortedList.FormattingEnabled = true;
            this.UnsortedList.Location = new System.Drawing.Point(3, 16);
            this.UnsortedList.Name = "UnsortedList";
            this.UnsortedList.Size = new System.Drawing.Size(119, 241);
            this.UnsortedList.TabIndex = 1;
            this.UnsortedList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnsortedList_MouseDown);
            // 
            // RandomItemsBox
            // 
            this.RandomItemsBox.Controls.Add(this.UnsortedList);
            this.RandomItemsBox.Location = new System.Drawing.Point(12, 12);
            this.RandomItemsBox.Name = "RandomItemsBox";
            this.RandomItemsBox.Size = new System.Drawing.Size(125, 260);
            this.RandomItemsBox.TabIndex = 2;
            this.RandomItemsBox.TabStop = false;
            this.RandomItemsBox.Text = "Unsorted Books";
            // 
            // SortedBox
            // 
            this.SortedBox.Controls.Add(this.SortedList);
            this.SortedBox.Location = new System.Drawing.Point(497, 9);
            this.SortedBox.Name = "SortedBox";
            this.SortedBox.Size = new System.Drawing.Size(125, 260);
            this.SortedBox.TabIndex = 3;
            this.SortedBox.TabStop = false;
            this.SortedBox.Text = "Sorted Books";
            // 
            // SortedList
            // 
            this.SortedList.AllowDrop = true;
            this.SortedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SortedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortedList.FormattingEnabled = true;
            this.SortedList.Location = new System.Drawing.Point(3, 16);
            this.SortedList.Name = "SortedList";
            this.SortedList.Size = new System.Drawing.Size(119, 241);
            this.SortedList.TabIndex = 1;
            this.SortedList.SelectedIndexChanged += new System.EventHandler(this.SortedList_SelectedIndexChanged);
            this.SortedList.DragDrop += new System.Windows.Forms.DragEventHandler(this.SortedList_DragDrop);
            this.SortedList.DragEnter += new System.Windows.Forms.DragEventHandler(this.SortedList_DragEnter);
            // 
            // ItemUpButton
            // 
            this.ItemUpButton.Location = new System.Drawing.Point(6, 19);
            this.ItemUpButton.Name = "ItemUpButton";
            this.ItemUpButton.Size = new System.Drawing.Size(75, 23);
            this.ItemUpButton.TabIndex = 2;
            this.ItemUpButton.Text = "Up";
            this.ItemUpButton.UseVisualStyleBackColor = true;
            this.ItemUpButton.Click += new System.EventHandler(this.ItemUpButton_Click);
            // 
            // ItemDownButton
            // 
            this.ItemDownButton.Location = new System.Drawing.Point(6, 48);
            this.ItemDownButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ItemDownButton.Name = "ItemDownButton";
            this.ItemDownButton.Size = new System.Drawing.Size(75, 23);
            this.ItemDownButton.TabIndex = 4;
            this.ItemDownButton.Text = "Down";
            this.ItemDownButton.UseVisualStyleBackColor = true;
            this.ItemDownButton.Click += new System.EventHandler(this.ItemDownButton_Click);
            // 
            // SortControlBox
            // 
            this.SortControlBox.AutoSize = true;
            this.SortControlBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SortControlBox.Controls.Add(this.ItemUpButton);
            this.SortControlBox.Controls.Add(this.ItemDownButton);
            this.SortControlBox.Location = new System.Drawing.Point(521, 272);
            this.SortControlBox.Name = "SortControlBox";
            this.SortControlBox.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.SortControlBox.Size = new System.Drawing.Size(87, 84);
            this.SortControlBox.TabIndex = 5;
            this.SortControlBox.TabStop = false;
            this.SortControlBox.Text = "Sorting";
            // 
            // InstructionBox
            // 
            this.InstructionBox.Controls.Add(this.InstructionLableOne);
            this.InstructionBox.Location = new System.Drawing.Point(159, 12);
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.Size = new System.Drawing.Size(200, 150);
            this.InstructionBox.TabIndex = 6;
            this.InstructionBox.TabStop = false;
            this.InstructionBox.Text = "Instructions";
            // 
            // InstructionLableOne
            // 
            this.InstructionLableOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionLableOne.Location = new System.Drawing.Point(3, 16);
            this.InstructionLableOne.Name = "InstructionLableOne";
            this.InstructionLableOne.Size = new System.Drawing.Size(194, 131);
            this.InstructionLableOne.TabIndex = 0;
            this.InstructionLableOne.Text = resources.GetString("InstructionLableOne.Text");
            this.InstructionLableOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinishBox
            // 
            this.FinishBox.AutoSize = true;
            this.FinishBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FinishBox.Controls.Add(this.FinishButton);
            this.FinishBox.Location = new System.Drawing.Point(15, 278);
            this.FinishBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.FinishBox.Name = "FinishBox";
            this.FinishBox.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.FinishBox.Size = new System.Drawing.Size(87, 55);
            this.FinishBox.TabIndex = 8;
            this.FinishBox.TabStop = false;
            this.FinishBox.Text = "Finish";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(6, 19);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 0;
            this.FinishButton.Text = "Complete";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // ScoreBox
            // 
            this.ScoreBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScoreBox.Controls.Add(this.ScoreLabel);
            this.ScoreBox.Location = new System.Drawing.Point(159, 278);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(87, 55);
            this.ScoreBox.TabIndex = 9;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "Score";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreLabel.Location = new System.Drawing.Point(3, 16);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(81, 36);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeBox
            // 
            this.TimeBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimeBox.Controls.Add(this.TimeLabel);
            this.TimeBox.Location = new System.Drawing.Point(286, 278);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(87, 55);
            this.TimeBox.TabIndex = 10;
            this.TimeBox.TabStop = false;
            this.TimeBox.Text = "Time";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLabel.Location = new System.Drawing.Point(3, 16);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(81, 36);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTimer
            // 
            this.UserTimer.Interval = 1000;
            this.UserTimer.Tick += new System.EventHandler(this.UserTimer_Tick);
            // 
            // DatabaseBox
            // 
            this.DatabaseBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DatabaseBox.Controls.Add(this.DatabaseTimeLabel);
            this.DatabaseBox.Location = new System.Drawing.Point(404, 278);
            this.DatabaseBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DatabaseBox.Name = "DatabaseBox";
            this.DatabaseBox.Size = new System.Drawing.Size(87, 55);
            this.DatabaseBox.TabIndex = 11;
            this.DatabaseBox.TabStop = false;
            this.DatabaseBox.Text = "Time-To-Beat";
            // 
            // DatabaseTimeLabel
            // 
            this.DatabaseTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseTimeLabel.Location = new System.Drawing.Point(3, 16);
            this.DatabaseTimeLabel.Name = "DatabaseTimeLabel";
            this.DatabaseTimeLabel.Size = new System.Drawing.Size(81, 36);
            this.DatabaseTimeLabel.TabIndex = 1;
            this.DatabaseTimeLabel.Text = "0";
            this.DatabaseTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EasyButton
            // 
            this.EasyButton.AutoSize = true;
            this.EasyButton.Checked = true;
            this.EasyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EasyButton.Enabled = false;
            this.EasyButton.Location = new System.Drawing.Point(3, 16);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(81, 17);
            this.EasyButton.TabIndex = 12;
            this.EasyButton.TabStop = true;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            // 
            // DiffcultyBox
            // 
            this.DiffcultyBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DiffcultyBox.Controls.Add(this.HardButton);
            this.DiffcultyBox.Controls.Add(this.MediumButton);
            this.DiffcultyBox.Controls.Add(this.EasyButton);
            this.DiffcultyBox.Location = new System.Drawing.Point(159, 168);
            this.DiffcultyBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DiffcultyBox.Name = "DiffcultyBox";
            this.DiffcultyBox.Size = new System.Drawing.Size(87, 71);
            this.DiffcultyBox.TabIndex = 13;
            this.DiffcultyBox.TabStop = false;
            this.DiffcultyBox.Text = "Diffculty";
            // 
            // HardButton
            // 
            this.HardButton.AutoSize = true;
            this.HardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HardButton.Enabled = false;
            this.HardButton.Location = new System.Drawing.Point(3, 50);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(81, 17);
            this.HardButton.TabIndex = 14;
            this.HardButton.TabStop = true;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = true;
            // 
            // MediumButton
            // 
            this.MediumButton.AutoSize = true;
            this.MediumButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MediumButton.Enabled = false;
            this.MediumButton.Location = new System.Drawing.Point(3, 33);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(81, 17);
            this.MediumButton.TabIndex = 13;
            this.MediumButton.TabStop = true;
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            // 
            // ClearBox
            // 
            this.ClearBox.AutoSize = true;
            this.ClearBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearBox.Controls.Add(this.ClearButton);
            this.ClearBox.Location = new System.Drawing.Point(404, 9);
            this.ClearBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ClearBox.Name = "ClearBox";
            this.ClearBox.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ClearBox.Size = new System.Drawing.Size(87, 55);
            this.ClearBox.TabIndex = 9;
            this.ClearBox.TabStop = false;
            this.ClearBox.Text = "Clear";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 19);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear List";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SortingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.ClearBox);
            this.Controls.Add(this.DiffcultyBox);
            this.Controls.Add(this.DatabaseBox);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.FinishBox);
            this.Controls.Add(this.InstructionBox);
            this.Controls.Add(this.SortControlBox);
            this.Controls.Add(this.SortedBox);
            this.Controls.Add(this.RandomItemsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Sorting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SortingWindow_FormClosed);
            this.Load += new System.EventHandler(this.SortingWindow_Load);
            this.RandomItemsBox.ResumeLayout(false);
            this.SortedBox.ResumeLayout(false);
            this.SortControlBox.ResumeLayout(false);
            this.InstructionBox.ResumeLayout(false);
            this.FinishBox.ResumeLayout(false);
            this.ScoreBox.ResumeLayout(false);
            this.TimeBox.ResumeLayout(false);
            this.DatabaseBox.ResumeLayout(false);
            this.DiffcultyBox.ResumeLayout(false);
            this.DiffcultyBox.PerformLayout();
            this.ClearBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UnsortedList;
        private System.Windows.Forms.GroupBox RandomItemsBox;
        private System.Windows.Forms.GroupBox SortedBox;
        private System.Windows.Forms.ListBox SortedList;
        private System.Windows.Forms.Button ItemUpButton;
        private System.Windows.Forms.Button ItemDownButton;
        private System.Windows.Forms.GroupBox SortControlBox;
        private System.Windows.Forms.GroupBox InstructionBox;
        private System.Windows.Forms.Label InstructionLableOne;
        private System.Windows.Forms.GroupBox FinishBox;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.GroupBox TimeBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer UserTimer;
        private System.Windows.Forms.GroupBox DatabaseBox;
        private System.Windows.Forms.Label DatabaseTimeLabel;
        private System.Windows.Forms.RadioButton EasyButton;
        private System.Windows.Forms.GroupBox DiffcultyBox;
        private System.Windows.Forms.RadioButton HardButton;
        private System.Windows.Forms.RadioButton MediumButton;
        private System.Windows.Forms.GroupBox ClearBox;
        private System.Windows.Forms.Button ClearButton;
    }
}