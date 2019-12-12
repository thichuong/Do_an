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
            this.OpacityLb = new System.Windows.Forms.Label();
            this.ThicknessLb = new System.Windows.Forms.Label();
            this.ThicknessSlide = new Bunifu.Framework.UI.BunifuSlider();
            this.OpacitySlide = new Bunifu.Framework.UI.BunifuSlider();
            this.ThicknessTb = new System.Windows.Forms.TextBox();
            this.OpacityTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // ThicknessSlide
            // 
            this.ThicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.ThicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.ThicknessSlide.BorderRadius = 0;
            this.ThicknessSlide.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.ThicknessSlide.Location = new System.Drawing.Point(33, 64);
            this.ThicknessSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThicknessSlide.MaximumValue = 30;
            this.ThicknessSlide.Name = "ThicknessSlide";
            this.ThicknessSlide.Size = new System.Drawing.Size(268, 41);
            this.ThicknessSlide.TabIndex = 31;
            this.ThicknessSlide.Value = 10;
            // 
            // OpacitySlide
            // 
            this.OpacitySlide.BackColor = System.Drawing.Color.Transparent;
            this.OpacitySlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.OpacitySlide.BorderRadius = 0;
            this.OpacitySlide.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.OpacitySlide.Location = new System.Drawing.Point(33, 167);
            this.OpacitySlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpacitySlide.MaximumValue = 255;
            this.OpacitySlide.Name = "OpacitySlide";
            this.OpacitySlide.Size = new System.Drawing.Size(268, 41);
            this.OpacitySlide.TabIndex = 32;
            this.OpacitySlide.Value = 255;
            // 
            // ThicknessTb
            // 
            this.ThicknessTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThicknessTb.Location = new System.Drawing.Point(232, 21);
            this.ThicknessTb.Name = "ThicknessTb";
            this.ThicknessTb.Size = new System.Drawing.Size(69, 35);
            this.ThicknessTb.TabIndex = 33;
            this.ThicknessTb.Text = "10";
            this.ThicknessTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ThicknessTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BrushesPropeties_KeyPress);
            // 
            // OpacityTb
            // 
            this.OpacityTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpacityTb.Location = new System.Drawing.Point(232, 130);
            this.OpacityTb.Name = "OpacityTb";
            this.OpacityTb.Size = new System.Drawing.Size(69, 35);
            this.OpacityTb.TabIndex = 33;
            this.OpacityTb.Text = "255";
            this.OpacityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OpacityTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OpacityTb_KeyPress);
            // 
            // BrushesPropeties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpacityTb);
            this.Controls.Add(this.ThicknessTb);
            this.Controls.Add(this.OpacitySlide);
            this.Controls.Add(this.ThicknessSlide);
            this.Controls.Add(this.OpacityLb);
            this.Controls.Add(this.ThicknessLb);
            this.Name = "BrushesPropeties";
            this.Size = new System.Drawing.Size(331, 215);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BrushesPropeties_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label OpacityLb;
        protected System.Windows.Forms.Label ThicknessLb;
        protected Bunifu.Framework.UI.BunifuSlider ThicknessSlide;
        protected Bunifu.Framework.UI.BunifuSlider OpacitySlide;
        protected System.Windows.Forms.TextBox ThicknessTb;
        protected System.Windows.Forms.TextBox OpacityTb;
    }
}
