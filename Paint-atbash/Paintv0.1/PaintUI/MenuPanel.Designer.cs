namespace PaintUI
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
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton5);
            this.bunifuGradientPanel1.Controls.Add(this.saveButton);
            this.bunifuGradientPanel1.Controls.Add(this.openButton);
            this.bunifuGradientPanel1.Controls.Add(this.newButton);
            this.bunifuGradientPanel1.Controls.Add(this.backButton);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(395, 761);
            this.bunifuGradientPanel1.TabIndex = 0;
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
            this.backButton.Size = new System.Drawing.Size(395, 124);
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
            this.newButton.Location = new System.Drawing.Point(0, 123);
            this.newButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newButton.Name = "newButton";
            this.newButton.Normalcolor = System.Drawing.Color.Transparent;
            this.newButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.newButton.OnHoverTextColor = System.Drawing.Color.White;
            this.newButton.selected = false;
            this.newButton.Size = new System.Drawing.Size(395, 124);
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
            this.openButton.Location = new System.Drawing.Point(0, 246);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openButton.Name = "openButton";
            this.openButton.Normalcolor = System.Drawing.Color.Transparent;
            this.openButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.openButton.OnHoverTextColor = System.Drawing.Color.White;
            this.openButton.selected = false;
            this.openButton.Size = new System.Drawing.Size(395, 124);
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
            this.saveButton.ButtonText = "Save As";
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
            this.saveButton.Location = new System.Drawing.Point(0, 369);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.Transparent;
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(395, 124);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save As";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 492);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(395, 124);
            this.bunifuFlatButton5.TabIndex = 0;
            this.bunifuFlatButton5.Text = "bunifuFlatButton1";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MenuPanelcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "MenuPanelcs";
            this.Size = new System.Drawing.Size(928, 761);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
        private Bunifu.Framework.UI.BunifuFlatButton openButton;
        private Bunifu.Framework.UI.BunifuFlatButton newButton;
        private Bunifu.Framework.UI.BunifuFlatButton backButton;
    }
}
