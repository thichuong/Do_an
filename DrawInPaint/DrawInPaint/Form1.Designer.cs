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
            this.RightColor = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.RecButton = new System.Windows.Forms.Button();
            this.PenButton = new System.Windows.Forms.Button();
            this.ElipseButton = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightColor
            // 
            this.RightColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightColor.AutoSize = true;
            this.RightColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightColor.ForeColor = System.Drawing.Color.NavajoWhite;
            this.RightColor.Location = new System.Drawing.Point(1191, 2);
            this.RightColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightColor.Name = "RightColor";
            this.RightColor.Size = new System.Drawing.Size(68, 58);
            this.RightColor.TabIndex = 4;
            this.RightColor.UseVisualStyleBackColor = false;
            this.RightColor.Click += new System.EventHandler(this.RightColor_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonPanel.Controls.Add(this.ComboBox1);
            this.ButtonPanel.Controls.Add(this.RecButton);
            this.ButtonPanel.Controls.Add(this.PenButton);
            this.ButtonPanel.Controls.Add(this.ElipseButton);
            this.ButtonPanel.Controls.Add(this.RightColor);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(1262, 62);
            this.ButtonPanel.TabIndex = 1;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(1077, 20);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(108, 24);
            this.ComboBox1.TabIndex = 3;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // RecButton
            // 
            this.RecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecButton.AutoSize = true;
            this.RecButton.Location = new System.Drawing.Point(914, 6);
            this.RecButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecButton.Name = "RecButton";
            this.RecButton.Size = new System.Drawing.Size(82, 50);
            this.RecButton.TabIndex = 1;
            this.RecButton.Text = "Rectangle";
            this.RecButton.UseVisualStyleBackColor = true;
            this.RecButton.Click += new System.EventHandler(this.RecButton_Click);
            // 
            // PenButton
            // 
            this.PenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PenButton.AutoSize = true;
            this.PenButton.Location = new System.Drawing.Point(839, 6);
            this.PenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(69, 50);
            this.PenButton.TabIndex = 0;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // ElipseButton
            // 
            this.ElipseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ElipseButton.AutoSize = true;
            this.ElipseButton.Location = new System.Drawing.Point(1002, 6);
            this.ElipseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ElipseButton.Name = "ElipseButton";
            this.ElipseButton.Size = new System.Drawing.Size(69, 50);
            this.ElipseButton.TabIndex = 2;
            this.ElipseButton.Text = "Ellipse";
            this.ElipseButton.UseVisualStyleBackColor = true;
            this.ElipseButton.Click += new System.EventHandler(this.ElipseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ButtonPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RightColor;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ElipseButton;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Button RecButton;
        private System.Windows.Forms.Button PenButton;
    }
}

