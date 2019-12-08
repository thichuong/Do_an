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
            this.ThicknessSlide = new Bunifu.Framework.UI.BunifuSlider();
            this.OpacityLb = new System.Windows.Forms.Label();
            this.OpacitySlide = new Bunifu.Framework.UI.BunifuSlider();
            this.ThicknessLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThicknessSlide
            // 
            this.ThicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.ThicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.ThicknessSlide.BorderRadius = 0;
            this.ThicknessSlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.ThicknessSlide.Location = new System.Drawing.Point(39, 72);
            this.ThicknessSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThicknessSlide.MaximumValue = 30;
            this.ThicknessSlide.Name = "ThicknessSlide";
            this.ThicknessSlide.Size = new System.Drawing.Size(259, 41);
            this.ThicknessSlide.TabIndex = 29;
            this.ThicknessSlide.Value = 5;
            // 
            // OpacityLb
            // 
            this.OpacityLb.AutoSize = true;
            this.OpacityLb.BackColor = System.Drawing.Color.Transparent;
            this.OpacityLb.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpacityLb.Location = new System.Drawing.Point(40, 119);
            this.OpacityLb.Name = "OpacityLb";
            this.OpacityLb.Size = new System.Drawing.Size(140, 52);
            this.OpacityLb.TabIndex = 28;
            this.OpacityLb.Text = "Opacity";
            // 
            // OpacitySlide
            // 
            this.OpacitySlide.BackColor = System.Drawing.Color.Transparent;
            this.OpacitySlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.OpacitySlide.BorderRadius = 0;
            this.OpacitySlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.OpacitySlide.Location = new System.Drawing.Point(40, 176);
            this.OpacitySlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpacitySlide.MaximumValue = 255;
            this.OpacitySlide.Name = "OpacitySlide";
            this.OpacitySlide.Size = new System.Drawing.Size(259, 41);
            this.OpacitySlide.TabIndex = 27;
            this.OpacitySlide.Value = 0;
            // 
            // ThicknessLb
            // 
            this.ThicknessLb.AutoSize = true;
            this.ThicknessLb.BackColor = System.Drawing.Color.Transparent;
            this.ThicknessLb.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThicknessLb.Location = new System.Drawing.Point(39, 10);
            this.ThicknessLb.Name = "ThicknessLb";
            this.ThicknessLb.Size = new System.Drawing.Size(166, 52);
            this.ThicknessLb.TabIndex = 26;
            this.ThicknessLb.Text = "Thickness";
            // 
            // BrushesPropeties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThicknessSlide);
            this.Controls.Add(this.OpacityLb);
            this.Controls.Add(this.OpacitySlide);
            this.Controls.Add(this.ThicknessLb);
            this.Name = "BrushesPropeties";
            this.Size = new System.Drawing.Size(331, 215);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Bunifu.Framework.UI.BunifuSlider ThicknessSlide;
        protected System.Windows.Forms.Label OpacityLb;
        protected Bunifu.Framework.UI.BunifuSlider OpacitySlide;
        protected System.Windows.Forms.Label ThicknessLb;
    }
}
