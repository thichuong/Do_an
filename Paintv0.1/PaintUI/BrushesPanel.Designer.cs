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
            this.Brushes_SizeSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label3 = new System.Windows.Forms.Label();
            this.Brushes_OpacitySlider = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label2 = new System.Windows.Forms.Label();
            this.Brushes_BrushesComboBox = new System.Windows.Forms.ComboBox();
            this.Brushes_Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Brushes_SizeSlider
            // 
            this.Brushes_SizeSlider.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_SizeSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Brushes_SizeSlider.BorderRadius = 0;
            this.Brushes_SizeSlider.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.Brushes_SizeSlider.Location = new System.Drawing.Point(35, 179);
            this.Brushes_SizeSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Brushes_SizeSlider.MaximumValue = 100;
            this.Brushes_SizeSlider.Name = "Brushes_SizeSlider";
            this.Brushes_SizeSlider.Size = new System.Drawing.Size(230, 35);
            this.Brushes_SizeSlider.TabIndex = 18;
            this.Brushes_SizeSlider.Value = 0;
            this.Brushes_SizeSlider.ValueChanged += new System.EventHandler(this.Brushes_SizeSlider_ValueChanged);
            // 
            // Brushes_Label3
            // 
            this.Brushes_Label3.AutoSize = true;
            this.Brushes_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label3.Location = new System.Drawing.Point(35, 230);
            this.Brushes_Label3.Name = "Brushes_Label3";
            this.Brushes_Label3.Size = new System.Drawing.Size(117, 43);
            this.Brushes_Label3.TabIndex = 17;
            this.Brushes_Label3.Text = "Opacity";
            // 
            // Brushes_OpacitySlider
            // 
            this.Brushes_OpacitySlider.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_OpacitySlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Brushes_OpacitySlider.BorderRadius = 0;
            this.Brushes_OpacitySlider.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.Brushes_OpacitySlider.Location = new System.Drawing.Point(35, 280);
            this.Brushes_OpacitySlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Brushes_OpacitySlider.MaximumValue = 100;
            this.Brushes_OpacitySlider.Name = "Brushes_OpacitySlider";
            this.Brushes_OpacitySlider.Size = new System.Drawing.Size(230, 35);
            this.Brushes_OpacitySlider.TabIndex = 16;
            this.Brushes_OpacitySlider.Value = 0;
            // 
            // Brushes_Label2
            // 
            this.Brushes_Label2.AutoSize = true;
            this.Brushes_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label2.Location = new System.Drawing.Point(35, 130);
            this.Brushes_Label2.Name = "Brushes_Label2";
            this.Brushes_Label2.Size = new System.Drawing.Size(68, 43);
            this.Brushes_Label2.TabIndex = 15;
            this.Brushes_Label2.Text = "Size";
            // 
            // Brushes_BrushesComboBox
            // 
            this.Brushes_BrushesComboBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Brushes_BrushesComboBox.FormattingEnabled = true;
            this.Brushes_BrushesComboBox.Location = new System.Drawing.Point(36, 68);
            this.Brushes_BrushesComboBox.Name = "Brushes_BrushesComboBox";
            this.Brushes_BrushesComboBox.Size = new System.Drawing.Size(230, 43);
            this.Brushes_BrushesComboBox.TabIndex = 14;
            // 
            // Brushes_Label1
            // 
            this.Brushes_Label1.AutoSize = true;
            this.Brushes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label1.Location = new System.Drawing.Point(35, 10);
            this.Brushes_Label1.Name = "Brushes_Label1";
            this.Brushes_Label1.Size = new System.Drawing.Size(116, 43);
            this.Brushes_Label1.TabIndex = 13;
            this.Brushes_Label1.Text = "Brushes";
            // 
            // BrushesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Brushes_SizeSlider);
            this.Controls.Add(this.Brushes_Label3);
            this.Controls.Add(this.Brushes_OpacitySlider);
            this.Controls.Add(this.Brushes_Label2);
            this.Controls.Add(this.Brushes_BrushesComboBox);
            this.Controls.Add(this.Brushes_Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BrushesPanel";
            this.Size = new System.Drawing.Size(335, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuSlider Brushes_SizeSlider;
        private System.Windows.Forms.Label Brushes_Label3;
        private Bunifu.Framework.UI.BunifuSlider Brushes_OpacitySlider;
        private System.Windows.Forms.Label Brushes_Label2;
        private System.Windows.Forms.ComboBox Brushes_BrushesComboBox;
        private System.Windows.Forms.Label Brushes_Label1;
    }
}
