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
            this.CallButton = new System.Windows.Forms.Button();
            this.AreaButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.SplitOne = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.SplitOne)).BeginInit();
            this.SplitOne.Panel1.SuspendLayout();
            this.SplitOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // CallButton
            // 
            this.CallButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CallButton.Enabled = false;
            this.CallButton.FlatAppearance.BorderSize = 0;
            this.CallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CallButton.Location = new System.Drawing.Point(0, 100);
            this.CallButton.Margin = new System.Windows.Forms.Padding(0);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(221, 50);
            this.CallButton.TabIndex = 2;
            this.CallButton.Text = "Call Numbers";
            this.CallButton.UseVisualStyleBackColor = true;
            // 
            // AreaButton
            // 
            this.AreaButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AreaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AreaButton.FlatAppearance.BorderSize = 0;
            this.AreaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaButton.Location = new System.Drawing.Point(0, 50);
            this.AreaButton.Margin = new System.Windows.Forms.Padding(0);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(221, 50);
            this.AreaButton.TabIndex = 1;
            this.AreaButton.Text = "Identify Areas";
            this.AreaButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SortButton.FlatAppearance.BorderSize = 0;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Location = new System.Drawing.Point(0, 0);
            this.SortButton.Margin = new System.Windows.Forms.Padding(0);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(221, 50);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Replace Books";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SplitOne
            // 
            this.SplitOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitOne.Location = new System.Drawing.Point(0, 0);
            this.SplitOne.Margin = new System.Windows.Forms.Padding(0);
            this.SplitOne.Name = "SplitOne";
            // 
            // SplitOne.Panel1
            // 
            this.SplitOne.Panel1.Controls.Add(this.CallButton);
            this.SplitOne.Panel1.Controls.Add(this.AreaButton);
            this.SplitOne.Panel1.Controls.Add(this.SortButton);
            // 
            // SplitOne.Panel2
            // 
            this.SplitOne.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.SplitOne.Size = new System.Drawing.Size(764, 476);
            this.SplitOne.SplitterDistance = 221;
            this.SplitOne.SplitterWidth = 1;
            this.SplitOne.TabIndex = 3;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(764, 476);
            this.Controls.Add(this.SplitOne);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Bag";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuWindow_FormClosed);
            this.SplitOne.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitOne)).EndInit();
            this.SplitOne.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.Button AreaButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.SplitContainer SplitOne;
    }
}

