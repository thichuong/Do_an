
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
            this.Brushes_Label1 = new System.Windows.Forms.Label();
            this.colorPanel = new PaintUI.ColorPanel();
            this.MarProp = new PaintUI.BrushesPropeties();
            this.CalliProp = new PaintUI.Code.Properties.CalligraphyProp();
            this.FillProp = new PaintUI.Code.Properties.FillProp();
            this.PelProp = new PaintUI.BrushesPropeties();
            this.SprProp = new PaintUI.BrushesPropeties();
            this.MultiProp = new BrushesPropeties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EraProp = new PaintUI.Code.Properties.CalligraphyProp();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.panel3);
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(225, 531);
            this.bunifuCards1.TabIndex = 1;
            // 
            // curBrushBtn
            // 
            this.curBrushBtn.Activecolor = System.Drawing.Color.Aqua;
            this.curBrushBtn.BackColor = System.Drawing.Color.Transparent;
            this.curBrushBtn.BackgroundImage = global::PaintUI.Properties.Resources.Artboard_1BaoKq;
            this.curBrushBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.curBrushBtn.ButtonText = "";
            this.curBrushBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.curBrushBtn.Location = new System.Drawing.Point(73, 45);
            this.curBrushBtn.Name = "curBrushBtn";
            this.curBrushBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.curBrushBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.curBrushBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.curBrushBtn.selected = false;
            this.curBrushBtn.Size = new System.Drawing.Size(56, 55);
            this.curBrushBtn.TabIndex = 27;
            this.curBrushBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.curBrushBtn.Textcolor = System.Drawing.Color.White;
            this.curBrushBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curBrushBtn.Click += new System.EventHandler(this.curBrushBtn_Click);
            // 
            // Brushes_Label1
            // 
            this.Brushes_Label1.AutoSize = true;
            this.Brushes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label1.Location = new System.Drawing.Point(54, 8);
            this.Brushes_Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Brushes_Label1.Name = "Brushes_Label1";
            this.Brushes_Label1.Size = new System.Drawing.Size(91, 35);
            this.Brushes_Label1.TabIndex = 21;
            this.Brushes_Label1.Text = "Brushes";
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Transparent;
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanel.Location = new System.Drawing.Point(0, 0);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(223, 261);
            this.colorPanel.TabIndex = 26;
            // 
            // MarProp
            // 
            this.MarProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarProp.Location = new System.Drawing.Point(0, 0);
            this.MarProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MarProp.Name = "MarProp";
            this.MarProp.Opacity = 255;
            this.MarProp.Size = new System.Drawing.Size(223, 171);
            this.MarProp.TabIndex = 28;
            this.MarProp.Thickness = 25;
            // 
            // CalliProp
            // 
            this.CalliProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalliProp.Location = new System.Drawing.Point(0, 0);
            this.CalliProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalliProp.Name = "CalliProp";
            this.CalliProp.Opacity = 255;
            this.CalliProp.Size = new System.Drawing.Size(223, 171);
            this.CalliProp.TabIndex = 29;
            this.CalliProp.Thickness = 25;
            // 
            // FillProp
            // 
            this.FillProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillProp.Location = new System.Drawing.Point(0, 0);
            this.FillProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillProp.Name = "FillProp";
            this.FillProp.Opacity = 255;
            this.FillProp.Size = new System.Drawing.Size(223, 171);
            this.FillProp.TabIndex = 31;
            this.FillProp.Thickness = 25;
            // 
            // PelProp
            // 
            this.PelProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PelProp.Location = new System.Drawing.Point(0, 0);
            this.PelProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PelProp.Name = "PelProp";
            this.PelProp.Opacity = 255;
            this.PelProp.Size = new System.Drawing.Size(223, 171);
            this.PelProp.TabIndex = 32;
            this.PelProp.Thickness = 25;
            // 
            // SprProp
            // 
            this.SprProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SprProp.Location = new System.Drawing.Point(0, 0);
            this.SprProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SprProp.Name = "SprProp";
            this.SprProp.Opacity = 255;
            this.SprProp.Size = new System.Drawing.Size(223, 171);
            this.SprProp.TabIndex = 33;
            this.SprProp.Thickness = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.curBrushBtn);
            this.panel1.Controls.Add(this.Brushes_Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 116);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EraProp);
            this.panel2.Controls.Add(this.MarProp);
            this.panel2.Controls.Add(this.SprProp);
            this.panel2.Controls.Add(this.PelProp);
            this.panel2.Controls.Add(this.CalliProp);
            this.panel2.Controls.Add(this.FillProp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 200);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.colorPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 230);
            this.panel3.TabIndex = 36;
            // 
            // EraProp
            // 
            this.EraProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EraProp.Location = new System.Drawing.Point(0, 0);
            this.EraProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EraProp.Name = "EraProp";
            this.EraProp.Opacity = 255;
            this.EraProp.Size = new System.Drawing.Size(223, 171);
            this.EraProp.TabIndex = 34;
            this.EraProp.Thickness = 25;
            //
            // MultiProp
            //
            this.MultiProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiProp.Location = new System.Drawing.Point(0, 0);
            this.MultiProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MultiProp.Name = "MultiProp";
            this.MultiProp.Opacity = 255;
            this.MultiProp.Size = new System.Drawing.Size(223, 171);
            this.MultiProp.TabIndex = 34;
            this.MultiProp.Thickness = 25;
            // 
            // BrushesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuCards1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BrushesPanel";
            this.Size = new System.Drawing.Size(225, 531);
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton curBrushBtn;
        private ColorPanel colorPanel;
        private System.Windows.Forms.Label Brushes_Label1;
        private Code.Properties.CalligraphyProp CalliProp;
        private BrushesPropeties MarProp;
        private Code.Properties.FillProp FillProp;
        private BrushesPropeties PelProp;
        private BrushesPropeties SprProp;
        private BrushesPropeties MultiProp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Code.Properties.CalligraphyProp EraProp;
    }
}

