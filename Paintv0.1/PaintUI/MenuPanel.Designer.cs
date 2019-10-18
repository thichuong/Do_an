﻿namespace PaintUI
{
    partial class MenuPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPanel));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.backButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.newButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveAsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.exitButton);
            this.bunifuGradientPanel1.Controls.Add(this.saveAsButton);
            this.bunifuGradientPanel1.Controls.Add(this.saveButton);
            this.bunifuGradientPanel1.Controls.Add(this.openButton);
            this.bunifuGradientPanel1.Controls.Add(this.newButton);
            this.bunifuGradientPanel1.Controls.Add(this.backButton);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(424, 694);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.BorderRadius = 0;
            this.backButton.ButtonText = "Back";
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.DisabledColor = System.Drawing.Color.Gray;
            this.backButton.Iconcolor = System.Drawing.Color.Transparent;
            this.backButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("backButton.Iconimage")));
            this.backButton.Iconimage_right = null;
            this.backButton.Iconimage_right_Selected = null;
            this.backButton.Iconimage_Selected = null;
            this.backButton.IconMarginLeft = 0;
            this.backButton.IconMarginRight = 0;
            this.backButton.IconRightVisible = true;
            this.backButton.IconRightZoom = 0D;
            this.backButton.IconVisible = true;
            this.backButton.IconZoom = 90D;
            this.backButton.IsTab = false;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Normalcolor = System.Drawing.Color.Transparent;
            this.backButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.backButton.OnHoverTextColor = System.Drawing.Color.White;
            this.backButton.selected = false;
            this.backButton.Size = new System.Drawing.Size(424, 112);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Textcolor = System.Drawing.Color.White;
            this.backButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newButton
            // 
            this.newButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.newButton.BackColor = System.Drawing.Color.Transparent;
            this.newButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newButton.BorderRadius = 0;
            this.newButton.ButtonText = "New";
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.DisabledColor = System.Drawing.Color.Gray;
            this.newButton.Iconcolor = System.Drawing.Color.Transparent;
            this.newButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("newButton.Iconimage")));
            this.newButton.Iconimage_right = null;
            this.newButton.Iconimage_right_Selected = null;
            this.newButton.Iconimage_Selected = null;
            this.newButton.IconMarginLeft = 0;
            this.newButton.IconMarginRight = 0;
            this.newButton.IconRightVisible = true;
            this.newButton.IconRightZoom = 0D;
            this.newButton.IconVisible = true;
            this.newButton.IconZoom = 90D;
            this.newButton.IsTab = false;
            this.newButton.Location = new System.Drawing.Point(0, 111);
            this.newButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newButton.Name = "newButton";
            this.newButton.Normalcolor = System.Drawing.Color.Transparent;
            this.newButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.newButton.OnHoverTextColor = System.Drawing.Color.White;
            this.newButton.selected = false;
            this.newButton.Size = new System.Drawing.Size(424, 112);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Textcolor = System.Drawing.Color.White;
            this.newButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // openButton
            // 
            this.openButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.openButton.BackColor = System.Drawing.Color.Transparent;
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openButton.BorderRadius = 0;
            this.openButton.ButtonText = "Open";
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.DisabledColor = System.Drawing.Color.Gray;
            this.openButton.Iconcolor = System.Drawing.Color.Transparent;
            this.openButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("openButton.Iconimage")));
            this.openButton.Iconimage_right = null;
            this.openButton.Iconimage_right_Selected = null;
            this.openButton.Iconimage_Selected = null;
            this.openButton.IconMarginLeft = 0;
            this.openButton.IconMarginRight = 0;
            this.openButton.IconRightVisible = true;
            this.openButton.IconRightZoom = 0D;
            this.openButton.IconVisible = true;
            this.openButton.IconZoom = 90D;
            this.openButton.IsTab = false;
            this.openButton.Location = new System.Drawing.Point(0, 222);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openButton.Name = "openButton";
            this.openButton.Normalcolor = System.Drawing.Color.Transparent;
            this.openButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.openButton.OnHoverTextColor = System.Drawing.Color.White;
            this.openButton.selected = false;
            this.openButton.Size = new System.Drawing.Size(424, 112);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.Textcolor = System.Drawing.Color.White;
            this.openButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // saveButton
            // 
            this.saveButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BorderRadius = 0;
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveButton.Iconimage")));
            this.saveButton.Iconimage_right = null;
            this.saveButton.Iconimage_right_Selected = null;
            this.saveButton.Iconimage_Selected = null;
            this.saveButton.IconMarginLeft = 0;
            this.saveButton.IconMarginRight = 0;
            this.saveButton.IconRightVisible = true;
            this.saveButton.IconRightZoom = 0D;
            this.saveButton.IconVisible = true;
            this.saveButton.IconZoom = 90D;
            this.saveButton.IsTab = false;
            this.saveButton.Location = new System.Drawing.Point(2, 333);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.Transparent;
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(424, 112);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // saveAsButton
            // 
            this.saveAsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveAsButton.BackColor = System.Drawing.Color.Transparent;
            this.saveAsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveAsButton.BorderRadius = 0;
            this.saveAsButton.ButtonText = "Save As";
            this.saveAsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAsButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveAsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveAsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Iconimage")));
            this.saveAsButton.Iconimage_right = null;
            this.saveAsButton.Iconimage_right_Selected = null;
            this.saveAsButton.Iconimage_Selected = null;
            this.saveAsButton.IconMarginLeft = 0;
            this.saveAsButton.IconMarginRight = 0;
            this.saveAsButton.IconRightVisible = true;
            this.saveAsButton.IconRightZoom = 0D;
            this.saveAsButton.IconVisible = true;
            this.saveAsButton.IconZoom = 90D;
            this.saveAsButton.IsTab = false;
            this.saveAsButton.Location = new System.Drawing.Point(0, 443);
            this.saveAsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.saveAsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveAsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveAsButton.selected = false;
            this.saveAsButton.Size = new System.Drawing.Size(424, 112);
            this.saveAsButton.TabIndex = 0;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAsButton.Textcolor = System.Drawing.Color.White;
            this.saveAsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // exitButton
            // 
            this.exitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.BorderRadius = 0;
            this.exitButton.ButtonText = "Exit";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledColor = System.Drawing.Color.Gray;
            this.exitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.exitButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("exitButton.Iconimage")));
            this.exitButton.Iconimage_right = null;
            this.exitButton.Iconimage_right_Selected = null;
            this.exitButton.Iconimage_Selected = null;
            this.exitButton.IconMarginLeft = 0;
            this.exitButton.IconMarginRight = 0;
            this.exitButton.IconRightVisible = true;
            this.exitButton.IconRightZoom = 0D;
            this.exitButton.IconVisible = true;
            this.exitButton.IconZoom = 90D;
            this.exitButton.IsTab = false;
            this.exitButton.Location = new System.Drawing.Point(0, 555);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.Transparent;
            this.exitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(424, 112);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Textcolor = System.Drawing.Color.White;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(420, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(509, 691);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(932, 694);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton saveAsButton;
        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
        private Bunifu.Framework.UI.BunifuFlatButton openButton;
        private Bunifu.Framework.UI.BunifuFlatButton newButton;
        private Bunifu.Framework.UI.BunifuFlatButton backButton;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
    }
}