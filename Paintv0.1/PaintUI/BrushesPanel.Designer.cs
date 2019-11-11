namespace PaintUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Brushes_SizeSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label3 = new System.Windows.Forms.Label();
            this.Brushes_OpacitySlider = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label2 = new System.Windows.Forms.Label();
            this.Brushes_BrushesComboBox = new System.Windows.Forms.ComboBox();
            this.Brushes_Label1 = new System.Windows.Forms.Label();
            this.Brushes_ForeColorBox = new System.Windows.Forms.PictureBox();
            this.Brushes_BackColorBox = new System.Windows.Forms.PictureBox();
            this.Brushes_MoreColorButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Brushes_ForeColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brushes_BackColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Brushes_ForeColorBox);
            this.panel1.Controls.Add(this.Brushes_BackColorBox);
            this.panel1.Controls.Add(this.Brushes_MoreColorButton);
            this.panel1.Controls.Add(this.Brushes_SizeSlider);
            this.panel1.Controls.Add(this.Brushes_Label3);
            this.panel1.Controls.Add(this.Brushes_OpacitySlider);
            this.panel1.Controls.Add(this.Brushes_Label2);
            this.panel1.Controls.Add(this.Brushes_BrushesComboBox);
            this.panel1.Controls.Add(this.Brushes_Label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(300, 551);
            this.panel1.TabIndex = 11;
            // 
            // Brushes_SizeSlider
            // 
            this.Brushes_SizeSlider.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_SizeSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Brushes_SizeSlider.BorderRadius = 0;
            this.Brushes_SizeSlider.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.Brushes_SizeSlider.Location = new System.Drawing.Point(40, 210);
            this.Brushes_SizeSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Brushes_SizeSlider.MaximumValue = 100;
            this.Brushes_SizeSlider.Name = "Brushes_SizeSlider";
            this.Brushes_SizeSlider.Size = new System.Drawing.Size(230, 35);
            this.Brushes_SizeSlider.TabIndex = 9;
            this.Brushes_SizeSlider.Value = 0;
            // 
            // Brushes_Label3
            // 
            this.Brushes_Label3.AutoSize = true;
            this.Brushes_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label3.Location = new System.Drawing.Point(40, 260);
            this.Brushes_Label3.Name = "Brushes_Label3";
            this.Brushes_Label3.Size = new System.Drawing.Size(117, 43);
            this.Brushes_Label3.TabIndex = 8;
            this.Brushes_Label3.Text = "Opacity";
            // 
            // Brushes_OpacitySlider
            // 
            this.Brushes_OpacitySlider.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_OpacitySlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Brushes_OpacitySlider.BorderRadius = 0;
            this.Brushes_OpacitySlider.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.Brushes_OpacitySlider.Location = new System.Drawing.Point(40, 310);
            this.Brushes_OpacitySlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Brushes_OpacitySlider.MaximumValue = 100;
            this.Brushes_OpacitySlider.Name = "Brushes_OpacitySlider";
            this.Brushes_OpacitySlider.Size = new System.Drawing.Size(230, 35);
            this.Brushes_OpacitySlider.TabIndex = 7;
            this.Brushes_OpacitySlider.Value = 0;
            // 
            // Brushes_Label2
            // 
            this.Brushes_Label2.AutoSize = true;
            this.Brushes_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label2.Location = new System.Drawing.Point(40, 160);
            this.Brushes_Label2.Name = "Brushes_Label2";
            this.Brushes_Label2.Size = new System.Drawing.Size(68, 43);
            this.Brushes_Label2.TabIndex = 5;
            this.Brushes_Label2.Text = "Size";
            // 
            // Brushes_BrushesComboBox
            // 
            this.Brushes_BrushesComboBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Brushes_BrushesComboBox.FormattingEnabled = true;
            this.Brushes_BrushesComboBox.Location = new System.Drawing.Point(40, 100);
            this.Brushes_BrushesComboBox.Name = "Brushes_BrushesComboBox";
            this.Brushes_BrushesComboBox.Size = new System.Drawing.Size(230, 43);
            this.Brushes_BrushesComboBox.TabIndex = 3;
            // 
            // Brushes_Label1
            // 
            this.Brushes_Label1.AutoSize = true;
            this.Brushes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label1.Location = new System.Drawing.Point(40, 40);
            this.Brushes_Label1.Name = "Brushes_Label1";
            this.Brushes_Label1.Size = new System.Drawing.Size(116, 43);
            this.Brushes_Label1.TabIndex = 0;
            this.Brushes_Label1.Text = "Brushes";
            // 
            // Brushes_ForeColorBox
            // 
            this.Brushes_ForeColorBox.BackColor = System.Drawing.Color.White;
            this.Brushes_ForeColorBox.Location = new System.Drawing.Point(80, 395);
            this.Brushes_ForeColorBox.Name = "Brushes_ForeColorBox";
            this.Brushes_ForeColorBox.Size = new System.Drawing.Size(82, 65);
            this.Brushes_ForeColorBox.TabIndex = 12;
            this.Brushes_ForeColorBox.TabStop = false;
            // 
            // Brushes_BackColorBox
            // 
            this.Brushes_BackColorBox.BackColor = System.Drawing.Color.Black;
            this.Brushes_BackColorBox.Location = new System.Drawing.Point(123, 369);
            this.Brushes_BackColorBox.Name = "Brushes_BackColorBox";
            this.Brushes_BackColorBox.Size = new System.Drawing.Size(82, 65);
            this.Brushes_BackColorBox.TabIndex = 11;
            this.Brushes_BackColorBox.TabStop = false;
            // 
            // Brushes_MoreColorButton
            // 
            this.Brushes_MoreColorButton.Activecolor = System.Drawing.Color.Silver;
            this.Brushes_MoreColorButton.BackColor = System.Drawing.Color.Gainsboro;
            this.Brushes_MoreColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Brushes_MoreColorButton.BorderRadius = 0;
            this.Brushes_MoreColorButton.ButtonText = "More Color";
            this.Brushes_MoreColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brushes_MoreColorButton.DisabledColor = System.Drawing.Color.Gray;
            this.Brushes_MoreColorButton.Iconcolor = System.Drawing.Color.Transparent;
            this.Brushes_MoreColorButton.Iconimage = global::PaintUI.Properties.Resources.brush4;
            this.Brushes_MoreColorButton.Iconimage_right = null;
            this.Brushes_MoreColorButton.Iconimage_right_Selected = null;
            this.Brushes_MoreColorButton.Iconimage_Selected = null;
            this.Brushes_MoreColorButton.IconMarginLeft = 0;
            this.Brushes_MoreColorButton.IconMarginRight = 0;
            this.Brushes_MoreColorButton.IconRightVisible = true;
            this.Brushes_MoreColorButton.IconRightZoom = 0D;
            this.Brushes_MoreColorButton.IconVisible = true;
            this.Brushes_MoreColorButton.IconZoom = 90D;
            this.Brushes_MoreColorButton.IsTab = false;
            this.Brushes_MoreColorButton.Location = new System.Drawing.Point(21, 478);
            this.Brushes_MoreColorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Brushes_MoreColorButton.Name = "Brushes_MoreColorButton";
            this.Brushes_MoreColorButton.Normalcolor = System.Drawing.Color.Gainsboro;
            this.Brushes_MoreColorButton.OnHovercolor = System.Drawing.Color.Silver;
            this.Brushes_MoreColorButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.Brushes_MoreColorButton.selected = false;
            this.Brushes_MoreColorButton.Size = new System.Drawing.Size(266, 59);
            this.Brushes_MoreColorButton.TabIndex = 10;
            this.Brushes_MoreColorButton.Text = "More Color";
            this.Brushes_MoreColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Brushes_MoreColorButton.Textcolor = System.Drawing.Color.Black;
            this.Brushes_MoreColorButton.TextFont = new System.Drawing.Font("Segoe Print", 12F);
            // 
            // BrushesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BrushesPanel";
            this.Size = new System.Drawing.Size(300, 551);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Brushes_ForeColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brushes_BackColorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Brushes_ForeColorBox;
        private System.Windows.Forms.PictureBox Brushes_BackColorBox;
        private Bunifu.Framework.UI.BunifuFlatButton Brushes_MoreColorButton;
        private Bunifu.Framework.UI.BunifuSlider Brushes_SizeSlider;
        private System.Windows.Forms.Label Brushes_Label3;
        private Bunifu.Framework.UI.BunifuSlider Brushes_OpacitySlider;
        private System.Windows.Forms.Label Brushes_Label2;
        private System.Windows.Forms.ComboBox Brushes_BrushesComboBox;
        private System.Windows.Forms.Label Brushes_Label1;
    }
}
