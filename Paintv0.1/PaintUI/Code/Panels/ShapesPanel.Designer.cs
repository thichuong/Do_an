namespace PaintUI
{
    partial class ShapesPanel
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
            this.thicknessSlide = new Bunifu.Framework.UI.BunifuSlider();
            this.curShapeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Shapes_OutlineCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Shapes_Label4 = new System.Windows.Forms.Label();
            this.Shapes_FillCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Shapes_Label3 = new System.Windows.Forms.Label();
            this.Shapes_Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPanel = new PaintUI.ColorPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.bunifuCards1.Size = new System.Drawing.Size(225, 458);
            this.bunifuCards1.TabIndex = 0;
            // 
            // thicknessSlide
            // 
            this.thicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.thicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.thicknessSlide.BorderRadius = 0;
            this.thicknessSlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.thicknessSlide.Location = new System.Drawing.Point(26, 60);
            this.thicknessSlide.MaximumValue = 30;
            this.thicknessSlide.Name = "thicknessSlide";
            this.thicknessSlide.Size = new System.Drawing.Size(172, 30);
            this.thicknessSlide.TabIndex = 51;
            this.thicknessSlide.Value = 5;
            // 
            // curShapeBtn
            // 
            this.curShapeBtn.Activecolor = System.Drawing.Color.Aqua;
            this.curShapeBtn.BackColor = System.Drawing.Color.Transparent;
            this.curShapeBtn.BackgroundImage = global::PaintUI.Properties.Resources.Rectangle1;
            this.curShapeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.curShapeBtn.BorderRadius = 0;
            this.curShapeBtn.ButtonText = "";
            this.curShapeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curShapeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.curShapeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.curShapeBtn.Iconimage = null;
            this.curShapeBtn.Iconimage_right = null;
            this.curShapeBtn.Iconimage_right_Selected = null;
            this.curShapeBtn.Iconimage_Selected = null;
            this.curShapeBtn.IconMarginLeft = 0;
            this.curShapeBtn.IconMarginRight = 0;
            this.curShapeBtn.IconRightVisible = true;
            this.curShapeBtn.IconRightZoom = 0D;
            this.curShapeBtn.IconVisible = true;
            this.curShapeBtn.IconZoom = 90D;
            this.curShapeBtn.IsTab = false;
            this.curShapeBtn.Location = new System.Drawing.Point(75, 47);
            this.curShapeBtn.Name = "curShapeBtn";
            this.curShapeBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.curShapeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.curShapeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.curShapeBtn.selected = false;
            this.curShapeBtn.Size = new System.Drawing.Size(51, 48);
            this.curShapeBtn.TabIndex = 50;
            this.curShapeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.curShapeBtn.Textcolor = System.Drawing.Color.White;
            this.curShapeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curShapeBtn.Click += new System.EventHandler(this.curShapeBtn_Click);
            // 
            // Shapes_OutlineCheckBox
            // 
            this.Shapes_OutlineCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Shapes_OutlineCheckBox.Checked = true;
            this.Shapes_OutlineCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ForeColor = System.Drawing.Color.White;
            this.Shapes_OutlineCheckBox.Location = new System.Drawing.Point(143, 25);
            this.Shapes_OutlineCheckBox.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Shapes_OutlineCheckBox.Name = "Shapes_OutlineCheckBox";
            this.Shapes_OutlineCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Shapes_OutlineCheckBox.TabIndex = 30;
            this.Shapes_OutlineCheckBox.OnChange += new System.EventHandler(this.Shapes_OutlineCheckBox_OnChange);
            // 
            // Shapes_Label4
            // 
            this.Shapes_Label4.AutoSize = true;
            this.Shapes_Label4.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label4.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label4.Location = new System.Drawing.Point(40, 14);
            this.Shapes_Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Shapes_Label4.Name = "Shapes_Label4";
            this.Shapes_Label4.Size = new System.Drawing.Size(87, 35);
            this.Shapes_Label4.TabIndex = 29;
            this.Shapes_Label4.Text = "Outline";
            // 
            // Shapes_FillCheckBox
            // 
            this.Shapes_FillCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Shapes_FillCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Shapes_FillCheckBox.Checked = true;
            this.Shapes_FillCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Shapes_FillCheckBox.ForeColor = System.Drawing.Color.White;
            this.Shapes_FillCheckBox.Location = new System.Drawing.Point(143, 114);
            this.Shapes_FillCheckBox.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Shapes_FillCheckBox.Name = "Shapes_FillCheckBox";
            this.Shapes_FillCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Shapes_FillCheckBox.TabIndex = 28;
            this.Shapes_FillCheckBox.OnChange += new System.EventHandler(this.Shapes_FillCheckBox_OnChange);
            // 
            // Shapes_Label3
            // 
            this.Shapes_Label3.AutoSize = true;
            this.Shapes_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label3.Location = new System.Drawing.Point(47, 105);
            this.Shapes_Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Shapes_Label3.Name = "Shapes_Label3";
            this.Shapes_Label3.Size = new System.Drawing.Size(45, 35);
            this.Shapes_Label3.TabIndex = 27;
            this.Shapes_Label3.Text = "Fill";
            // 
            // Shapes_Label1
            // 
            this.Shapes_Label1.AutoSize = true;
            this.Shapes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label1.Location = new System.Drawing.Point(62, 10);
            this.Shapes_Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Shapes_Label1.Name = "Shapes_Label1";
            this.Shapes_Label1.Size = new System.Drawing.Size(84, 35);
            this.Shapes_Label1.TabIndex = 26;
            this.Shapes_Label1.Text = "Shapes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Shapes_Label1);
            this.panel1.Controls.Add(this.curShapeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 100);
            this.panel1.TabIndex = 52;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Transparent;
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanel.Location = new System.Drawing.Point(0, 0);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(223, 168);
            this.colorPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Shapes_Label4);
            this.panel2.Controls.Add(this.Shapes_Label3);
            this.panel2.Controls.Add(this.Shapes_FillCheckBox);
            this.panel2.Controls.Add(this.Shapes_OutlineCheckBox);
            this.panel2.Controls.Add(this.thicknessSlide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 157);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.colorPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 168);
            this.panel3.TabIndex = 54;
            // 
            // ShapesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bunifuCards1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShapesPanel";
            this.Size = new System.Drawing.Size(225, 458);
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCheckbox Shapes_OutlineCheckBox;
        private System.Windows.Forms.Label Shapes_Label4;
        private Bunifu.Framework.UI.BunifuCheckbox Shapes_FillCheckBox;
        private System.Windows.Forms.Label Shapes_Label3;
        private System.Windows.Forms.Label Shapes_Label1;
        private ColorPanel colorPanel;
        private Bunifu.Framework.UI.BunifuFlatButton curShapeBtn;
        private Bunifu.Framework.UI.BunifuSlider thicknessSlide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
