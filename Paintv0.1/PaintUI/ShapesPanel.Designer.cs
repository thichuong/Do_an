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
            this.bunifuCards1.Controls.Add(this.thicknessSlide);
            this.bunifuCards1.Controls.Add(this.curShapeBtn);
            this.bunifuCards1.Controls.Add(this.Shapes_OutlineCheckBox);
            this.bunifuCards1.Controls.Add(this.Shapes_Label4);
            this.bunifuCards1.Controls.Add(this.Shapes_FillCheckBox);
            this.bunifuCards1.Controls.Add(this.Shapes_Label3);
            this.bunifuCards1.Controls.Add(this.Shapes_Label1);
            this.bunifuCards1.Controls.Add(this.colorPanel);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(338, 746);
            this.bunifuCards1.TabIndex = 0;
            // 
            // thicknessSlide
            // 
            this.thicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.thicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.thicknessSlide.BorderRadius = 0;
            this.thicknessSlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.thicknessSlide.Location = new System.Drawing.Point(55, 244);
            this.thicknessSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thicknessSlide.MaximumValue = 30;
            this.thicknessSlide.Name = "thicknessSlide";
            this.thicknessSlide.Size = new System.Drawing.Size(259, 41);
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
            this.curShapeBtn.Location = new System.Drawing.Point(133, 76);
            this.curShapeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curShapeBtn.Name = "curShapeBtn";
            this.curShapeBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.curShapeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.curShapeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.curShapeBtn.selected = false;
            this.curShapeBtn.Size = new System.Drawing.Size(76, 74);
            this.curShapeBtn.TabIndex = 50;
            this.curShapeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.curShapeBtn.Textcolor = System.Drawing.Color.White;
            this.curShapeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curShapeBtn.Click += new System.EventHandler(this.curShapeBtn_Click);
            this.curShapeBtn.Leave += new System.EventHandler(this.curShapeBtn_Leave);
            // 
            // Shapes_OutlineCheckBox
            // 
            this.Shapes_OutlineCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Shapes_OutlineCheckBox.Checked = true;
            this.Shapes_OutlineCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ForeColor = System.Drawing.Color.White;
            this.Shapes_OutlineCheckBox.Location = new System.Drawing.Point(232, 189);
            this.Shapes_OutlineCheckBox.Margin = new System.Windows.Forms.Padding(9, 14, 9, 14);
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
            this.Shapes_Label4.Location = new System.Drawing.Point(76, 172);
            this.Shapes_Label4.Name = "Shapes_Label4";
            this.Shapes_Label4.Size = new System.Drawing.Size(133, 52);
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
            this.Shapes_FillCheckBox.Location = new System.Drawing.Point(232, 326);
            this.Shapes_FillCheckBox.Margin = new System.Windows.Forms.Padding(9, 14, 9, 14);
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
            this.Shapes_Label3.Location = new System.Drawing.Point(88, 313);
            this.Shapes_Label3.Name = "Shapes_Label3";
            this.Shapes_Label3.Size = new System.Drawing.Size(68, 52);
            this.Shapes_Label3.TabIndex = 27;
            this.Shapes_Label3.Text = "Fill";
            // 
            // Shapes_Label1
            // 
            this.Shapes_Label1.AutoSize = true;
            this.Shapes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label1.Location = new System.Drawing.Point(113, 19);
            this.Shapes_Label1.Name = "Shapes_Label1";
            this.Shapes_Label1.Size = new System.Drawing.Size(127, 52);
            this.Shapes_Label1.TabIndex = 26;
            this.Shapes_Label1.Text = "Shapes";
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BackColor = System.Drawing.Color.Transparent;
            this.colorPanel.Location = new System.Drawing.Point(0, 400);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(338, 346);
            this.colorPanel.TabIndex = 1;
            // 
            // ShapesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bunifuCards1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShapesPanel";
            this.Size = new System.Drawing.Size(338, 746);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
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
    }
}
