
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
            this.thicknessSlide = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label3 = new System.Windows.Forms.Label();
            this.opacitySlide = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label2 = new System.Windows.Forms.Label();
            this.Brushes_BrushesComboBox = new System.Windows.Forms.ComboBox();
            this.Brushes_Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thicknessSlide
            // 
            this.thicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.thicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.thicknessSlide.BorderRadius = 0;
            this.thicknessSlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.thicknessSlide.Location = new System.Drawing.Point(39, 224);
            this.thicknessSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thicknessSlide.MaximumValue = 100;
            this.thicknessSlide.Name = "thicknessSlide";
            this.thicknessSlide.Size = new System.Drawing.Size(259, 41);
            this.thicknessSlide.TabIndex = 18;
            this.thicknessSlide.Value = 0;
            this.thicknessSlide.ValueChanged += new System.EventHandler(this.thicknessSlide_ValueChanged);
            // 
            // Brushes_Label3
            // 
            this.Brushes_Label3.AutoSize = true;
            this.Brushes_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label3.Location = new System.Drawing.Point(39, 287);
            this.Brushes_Label3.Name = "Brushes_Label3";
            this.Brushes_Label3.Size = new System.Drawing.Size(140, 52);
            this.Brushes_Label3.TabIndex = 17;
            this.Brushes_Label3.Text = "Opacity";
            // 
            // opacitySlide
            // 
            this.opacitySlide.BackColor = System.Drawing.Color.Transparent;
            this.opacitySlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.opacitySlide.BorderRadius = 0;
            this.opacitySlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.opacitySlide.Location = new System.Drawing.Point(39, 350);
            this.opacitySlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opacitySlide.MaximumValue = 255;
            this.opacitySlide.Name = "opacitySlide";
            this.opacitySlide.Size = new System.Drawing.Size(259, 41);
            this.opacitySlide.TabIndex = 16;
            this.opacitySlide.Value = 0;
            this.opacitySlide.ValueChanged += new System.EventHandler(this.opacitySlide_ValueChanged);
            // 
            // Brushes_Label2
            // 
            this.Brushes_Label2.AutoSize = true;
            this.Brushes_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label2.Location = new System.Drawing.Point(39, 162);
            this.Brushes_Label2.Name = "Brushes_Label2";
            this.Brushes_Label2.Size = new System.Drawing.Size(166, 52);
            this.Brushes_Label2.TabIndex = 15;
            this.Brushes_Label2.Text = "Thickness";
            // 
            // Brushes_BrushesComboBox
            // 
            this.Brushes_BrushesComboBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Brushes_BrushesComboBox.FormattingEnabled = true;
            this.Brushes_BrushesComboBox.Location = new System.Drawing.Point(40, 85);
            this.Brushes_BrushesComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Brushes_BrushesComboBox.Name = "Brushes_BrushesComboBox";
            this.Brushes_BrushesComboBox.Size = new System.Drawing.Size(258, 50);
            this.Brushes_BrushesComboBox.TabIndex = 14;
            // 
            // Brushes_Label1
            // 
            this.Brushes_Label1.AutoSize = true;
            this.Brushes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label1.Location = new System.Drawing.Point(39, 12);
            this.Brushes_Label1.Name = "Brushes_Label1";
            this.Brushes_Label1.Size = new System.Drawing.Size(139, 52);
            this.Brushes_Label1.TabIndex = 13;
            this.Brushes_Label1.Text = "Brushes";
            // 
            // BrushesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.thicknessSlide);
            this.Controls.Add(this.Brushes_Label3);
            this.Controls.Add(this.opacitySlide);
            this.Controls.Add(this.Brushes_Label2);
            this.Controls.Add(this.Brushes_BrushesComboBox);
            this.Controls.Add(this.Brushes_Label1);
            this.Name = "BrushesPanel";
            this.Size = new System.Drawing.Size(377, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuSlider thicknessSlide;
        private System.Windows.Forms.Label Brushes_Label3;
        private Bunifu.Framework.UI.BunifuSlider opacitySlide;
        private System.Windows.Forms.Label Brushes_Label2;
        private System.Windows.Forms.ComboBox Brushes_BrushesComboBox;
        private System.Windows.Forms.Label Brushes_Label1;
    }
}

