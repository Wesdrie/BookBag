namespace BookBag
{
    partial class MenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.ControlBox = new System.Windows.Forms.GroupBox();
            this.CallButton = new System.Windows.Forms.Button();
            this.AreaButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.NotesButton = new System.Windows.Forms.Button();
            this.ControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            this.ControlBox.AutoSize = true;
            this.ControlBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlBox.Controls.Add(this.CallButton);
            this.ControlBox.Controls.Add(this.AreaButton);
            this.ControlBox.Controls.Add(this.SortButton);
            this.ControlBox.Location = new System.Drawing.Point(269, 120);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(112, 119);
            this.ControlBox.TabIndex = 0;
            this.ControlBox.TabStop = false;
            this.ControlBox.Text = "Menu";
            // 
            // CallButton
            // 
            this.CallButton.Enabled = false;
            this.CallButton.Location = new System.Drawing.Point(6, 77);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(100, 23);
            this.CallButton.TabIndex = 2;
            this.CallButton.Text = "Call Numbers";
            this.CallButton.UseVisualStyleBackColor = true;
            // 
            // AreaButton
            // 
            this.AreaButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AreaButton.Enabled = false;
            this.AreaButton.Location = new System.Drawing.Point(6, 48);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(100, 23);
            this.AreaButton.TabIndex = 1;
            this.AreaButton.Text = "Identify Areas";
            this.AreaButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(6, 19);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(100, 23);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Replace Books";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // NotesButton
            // 
            this.NotesButton.Location = new System.Drawing.Point(547, 12);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(75, 23);
            this.NotesButton.TabIndex = 1;
            this.NotesButton.Text = "Version Notes";
            this.NotesButton.UseVisualStyleBackColor = true;
            this.NotesButton.Click += new System.EventHandler(this.NotesButton_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.NotesButton);
            this.Controls.Add(this.ControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Bag Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuWindow_FormClosed);
            this.ControlBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ControlBox;
        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.Button AreaButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button NotesButton;
    }
}

