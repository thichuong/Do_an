namespace PaintUI
{
    partial class BrushesPropeties
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
            this.opacityLb = new System.Windows.Forms.Label();
            this.opacitySlide = new Bunifu.Framework.UI.BunifuSlider();
            this.thicknessLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thicknessSlide
            // 
            this.thicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.thicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.thicknessSlide.BorderRadius = 0;
            this.thicknessSlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.thicknessSlide.Location = new System.Drawing.Point(39, 72);
            this.thicknessSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thicknessSlide.MaximumValue = 30;
            this.thicknessSlide.Name = "thicknessSlide";
            this.thicknessSlide.Size = new System.Drawing.Size(259, 41);
            this.thicknessSlide.TabIndex = 29;
            this.thicknessSlide.Value = 5;
            // 
            // opacityLb
            // 
            this.opacityLb.AutoSize = true;
            this.opacityLb.BackColor = System.Drawing.Color.Transparent;
            this.opacityLb.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opacityLb.Location = new System.Drawing.Point(40, 119);
            this.opacityLb.Name = "opacityLb";
            this.opacityLb.Size = new System.Drawing.Size(140, 52);
            this.opacityLb.TabIndex = 28;
            this.opacityLb.Text = "Opacity";
            // 
            // opacitySlide
            // 
            this.opacitySlide.BackColor = System.Drawing.Color.Transparent;
            this.opacitySlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.opacitySlide.BorderRadius = 0;
            this.opacitySlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.opacitySlide.Location = new System.Drawing.Point(40, 176);
            this.opacitySlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opacitySlide.MaximumValue = 255;
            this.opacitySlide.Name = "opacitySlide";
            this.opacitySlide.Size = new System.Drawing.Size(259, 41);
            this.opacitySlide.TabIndex = 27;
            this.opacitySlide.Value = 0;
            // 
            // thicknessLb
            // 
            this.thicknessLb.AutoSize = true;
            this.thicknessLb.BackColor = System.Drawing.Color.Transparent;
            this.thicknessLb.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thicknessLb.Location = new System.Drawing.Point(39, 10);
            this.thicknessLb.Name = "thicknessLb";
            this.thicknessLb.Size = new System.Drawing.Size(166, 52);
            this.thicknessLb.TabIndex = 26;
            this.thicknessLb.Text = "Thickness";
            // 
            // BrushesPropeties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.thicknessSlide);
            this.Controls.Add(this.opacityLb);
            this.Controls.Add(this.opacitySlide);
            this.Controls.Add(this.thicknessLb);
            this.Name = "BrushesPropeties";
            this.Size = new System.Drawing.Size(331, 215);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSlider thicknessSlide;
        private System.Windows.Forms.Label opacityLb;
        private Bunifu.Framework.UI.BunifuSlider opacitySlide;
        private System.Windows.Forms.Label thicknessLb;
    }
}
