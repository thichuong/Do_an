namespace DrawInPaint
{
    partial class Form1
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
            this.foreColor = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.EraserButton = new System.Windows.Forms.Button();
            this.FillButton = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.RecButton = new System.Windows.Forms.Button();
            this.BrushButton = new System.Windows.Forms.Button();
            this.ElipseButton = new System.Windows.Forms.Button();
            this.backColor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // foreColor
            // 
            this.foreColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.foreColor.ForeColor = System.Drawing.Color.NavajoWhite;
            this.foreColor.Location = new System.Drawing.Point(700, 4);
            this.foreColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foreColor.Name = "foreColor";
            this.foreColor.Size = new System.Drawing.Size(68, 58);
            this.foreColor.TabIndex = 4;
            this.foreColor.UseVisualStyleBackColor = false;
            this.foreColor.Click += new System.EventHandler(this.ForeColor_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonPanel.Controls.Add(this.EraserButton);
            this.ButtonPanel.Controls.Add(this.FillButton);
            this.ButtonPanel.Controls.Add(this.ComboBox1);
            this.ButtonPanel.Controls.Add(this.RecButton);
            this.ButtonPanel.Controls.Add(this.BrushButton);
            this.ButtonPanel.Controls.Add(this.ElipseButton);
            this.ButtonPanel.Controls.Add(this.backColor);
            this.ButtonPanel.Controls.Add(this.foreColor);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 30);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(1036, 72);
            this.ButtonPanel.TabIndex = 1;
            // 
            // EraserButton
            // 
            this.EraserButton.BackColor = System.Drawing.Color.White;
            this.EraserButton.Location = new System.Drawing.Point(242, 12);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(75, 50);
            this.EraserButton.TabIndex = 5;
            this.EraserButton.UseVisualStyleBackColor = false;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // FillButton
            // 
            this.FillButton.BackColor = System.Drawing.Color.White;
            this.FillButton.Location = new System.Drawing.Point(150, 12);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 50);
            this.FillButton.TabIndex = 0;
            this.FillButton.UseVisualStyleBackColor = false;
            this.FillButton.Click += new System.EventHandler(this.FillBucketButton_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(573, 26);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(108, 24);
            this.ComboBox1.TabIndex = 3;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // RecButton
            // 
            this.RecButton.Location = new System.Drawing.Point(394, 11);
            this.RecButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecButton.Name = "RecButton";
            this.RecButton.Size = new System.Drawing.Size(69, 50);
            this.RecButton.TabIndex = 1;
            this.RecButton.Text = "Rectangle";
            this.RecButton.UseVisualStyleBackColor = true;
            this.RecButton.Click += new System.EventHandler(this.RecButton_Click);
            // 
            // BrushButton
            // 
            this.BrushButton.BackColor = System.Drawing.Color.White;
            this.BrushButton.Location = new System.Drawing.Point(59, 12);
            this.BrushButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(69, 50);
            this.BrushButton.TabIndex = 0;
            this.BrushButton.UseVisualStyleBackColor = false;
            this.BrushButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // ElipseButton
            // 
            this.ElipseButton.Location = new System.Drawing.Point(481, 12);
            this.ElipseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ElipseButton.Name = "ElipseButton";
            this.ElipseButton.Size = new System.Drawing.Size(69, 50);
            this.ElipseButton.TabIndex = 2;
            this.ElipseButton.Text = "Ellipse";
            this.ElipseButton.UseVisualStyleBackColor = true;
            this.ElipseButton.Click += new System.EventHandler(this.ElipseButton_Click);
            // 
            // backColor
            // 
            this.backColor.BackColor = System.Drawing.Color.White;
            this.backColor.ForeColor = System.Drawing.Color.NavajoWhite;
            this.backColor.Location = new System.Drawing.Point(784, 4);
            this.backColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backColor.Name = "backColor";
            this.backColor.Size = new System.Drawing.Size(68, 58);
            this.backColor.TabIndex = 4;
            this.backColor.UseVisualStyleBackColor = false;
            this.backColor.Click += new System.EventHandler(this.BackColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1036, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 411);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.Picture1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Picture1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1036, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1006, 560);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ButtonPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
        }

        #endregion
        private System.Windows.Forms.Button foreColor;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ElipseButton;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Button RecButton;
        private System.Windows.Forms.Button BrushButton;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button backColor;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

