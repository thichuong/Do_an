
﻿namespace PaintUI
{
    partial class BrushesPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.curBrushBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.thicknessSlide = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label3 = new System.Windows.Forms.Label();
            this.opacitySlide = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label2 = new System.Windows.Forms.Label();
            this.Brushes_Label1 = new System.Windows.Forms.Label();
            this.colorPanel = new PaintUI.ColorPanel();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.curBrushBtn);
            this.bunifuCards1.Controls.Add(this.colorPanel);
            this.bunifuCards1.Controls.Add(this.thicknessSlide);
            this.bunifuCards1.Controls.Add(this.Brushes_Label3);
            this.bunifuCards1.Controls.Add(this.opacitySlide);
            this.bunifuCards1.Controls.Add(this.Brushes_Label2);
            this.bunifuCards1.Controls.Add(this.Brushes_Label1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(338, 746);
            this.bunifuCards1.TabIndex = 1;
            // 
            // curBrushBtn
            // 
            this.curBrushBtn.Activecolor = System.Drawing.Color.Aqua;
            this.curBrushBtn.BackColor = System.Drawing.Color.Transparent;
            this.curBrushBtn.BackgroundImage = global::PaintUI.Properties.Resources.Artboard_1BaoKq;
            this.curBrushBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.curBrushBtn.BorderRadius = 0;
            this.curBrushBtn.ButtonText = "";
            this.curBrushBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curBrushBtn.DisabledColor = System.Drawing.Color.Gray;
            this.curBrushBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.curBrushBtn.Iconimage = null;
            this.curBrushBtn.Iconimage_right = null;
            this.curBrushBtn.Iconimage_right_Selected = null;
            this.curBrushBtn.Iconimage_Selected = null;
            this.curBrushBtn.IconMarginLeft = 0;
            this.curBrushBtn.IconMarginRight = 0;
            this.curBrushBtn.IconRightVisible = true;
            this.curBrushBtn.IconRightZoom = 0D;
            this.curBrushBtn.IconVisible = true;
            this.curBrushBtn.IconZoom = 90D;
            this.curBrushBtn.IsTab = false;
            this.curBrushBtn.Location = new System.Drawing.Point(128, 88);
            this.curBrushBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curBrushBtn.Name = "curBrushBtn";
            this.curBrushBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.curBrushBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.curBrushBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.curBrushBtn.selected = false;
            this.curBrushBtn.Size = new System.Drawing.Size(83, 85);
            this.curBrushBtn.TabIndex = 27;
            this.curBrushBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.curBrushBtn.Textcolor = System.Drawing.Color.White;
            this.curBrushBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curBrushBtn.Click += new System.EventHandler(this.curBrushBtn_Click);
            // 
            // thicknessSlide
            // 
            this.thicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.thicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.thicknessSlide.BorderRadius = 0;
            this.thicknessSlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.thicknessSlide.Location = new System.Drawing.Point(45, 253);
            this.thicknessSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thicknessSlide.MaximumValue = 30;
            this.thicknessSlide.Name = "thicknessSlide";
            this.thicknessSlide.Size = new System.Drawing.Size(259, 41);
            this.thicknessSlide.TabIndex = 25;
            this.thicknessSlide.Value = 5;
            // 
            // Brushes_Label3
            // 
            this.Brushes_Label3.AutoSize = true;
            this.Brushes_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label3.Location = new System.Drawing.Point(46, 300);
            this.Brushes_Label3.Name = "Brushes_Label3";
            this.Brushes_Label3.Size = new System.Drawing.Size(140, 52);
            this.Brushes_Label3.TabIndex = 24;
            this.Brushes_Label3.Text = "Opacity";
            // 
            // opacitySlide
            // 
            this.opacitySlide.BackColor = System.Drawing.Color.Transparent;
            this.opacitySlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.opacitySlide.BorderRadius = 0;
            this.opacitySlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.opacitySlide.Location = new System.Drawing.Point(46, 357);
            this.opacitySlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opacitySlide.MaximumValue = 255;
            this.opacitySlide.Name = "opacitySlide";
            this.opacitySlide.Size = new System.Drawing.Size(259, 41);
            this.opacitySlide.TabIndex = 23;
            this.opacitySlide.Value = 0;
            // 
            // Brushes_Label2
            // 
            this.Brushes_Label2.AutoSize = true;
            this.Brushes_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label2.Location = new System.Drawing.Point(45, 191);
            this.Brushes_Label2.Name = "Brushes_Label2";
            this.Brushes_Label2.Size = new System.Drawing.Size(166, 52);
            this.Brushes_Label2.TabIndex = 22;
            this.Brushes_Label2.Text = "Thickness";
            // 
            // Brushes_Label1
            // 
            this.Brushes_Label1.AutoSize = true;
            this.Brushes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label1.Location = new System.Drawing.Point(100, 30);
            this.Brushes_Label1.Name = "Brushes_Label1";
            this.Brushes_Label1.Size = new System.Drawing.Size(139, 52);
            this.Brushes_Label1.TabIndex = 21;
            this.Brushes_Label1.Text = "Brushes";
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BackColor = System.Drawing.Color.Transparent;
            this.colorPanel.Location = new System.Drawing.Point(0, 393);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(338, 347);
            this.colorPanel.TabIndex = 26;
            // 
            // BrushesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "BrushesPanel";
            this.Size = new System.Drawing.Size(338, 746);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton curBrushBtn;
        private ColorPanel colorPanel;
        private Bunifu.Framework.UI.BunifuSlider thicknessSlide;
        private System.Windows.Forms.Label Brushes_Label3;
        private Bunifu.Framework.UI.BunifuSlider opacitySlide;
        private System.Windows.Forms.Label Brushes_Label2;
        private System.Windows.Forms.Label Brushes_Label1;
    }
}

