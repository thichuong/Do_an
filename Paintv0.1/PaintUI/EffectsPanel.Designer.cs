namespace PaintUI
{
    partial class EffectsPanel
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
            this.Effects_Label1 = new System.Windows.Forms.Label();
            this.Effects_EffectsComboBox = new System.Windows.Forms.ComboBox();
            this.Effects_Label2 = new System.Windows.Forms.Label();
            this.Effect_ValueSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.SuspendLayout();
            // 
            // Effects_Label1
            // 
            this.Effects_Label1.AutoSize = true;
            this.Effects_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Effects_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Effects_Label1.Location = new System.Drawing.Point(77, 21);
            this.Effects_Label1.Name = "Effects_Label1";
            this.Effects_Label1.Size = new System.Drawing.Size(124, 52);
            this.Effects_Label1.TabIndex = 1;
            this.Effects_Label1.Text = "Effects";
            // 
            // Effects_EffectsComboBox
            // 
            this.Effects_EffectsComboBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Effects_EffectsComboBox.FormattingEnabled = true;
            this.Effects_EffectsComboBox.Location = new System.Drawing.Point(11, 100);
            this.Effects_EffectsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Effects_EffectsComboBox.Name = "Effects_EffectsComboBox";
            this.Effects_EffectsComboBox.Size = new System.Drawing.Size(258, 50);
            this.Effects_EffectsComboBox.TabIndex = 4;
            // 
            // Effects_Label2
            // 
            this.Effects_Label2.AutoSize = true;
            this.Effects_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Effects_Label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Effects_Label2.Location = new System.Drawing.Point(77, 178);
            this.Effects_Label2.Name = "Effects_Label2";
            this.Effects_Label2.Size = new System.Drawing.Size(106, 52);
            this.Effects_Label2.TabIndex = 6;
            this.Effects_Label2.Text = "Value";
            // 
            // Effect_ValueSlider
            // 
            this.Effect_ValueSlider.BackColor = System.Drawing.Color.Transparent;
            this.Effect_ValueSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Effect_ValueSlider.BorderRadius = 0;
            this.Effect_ValueSlider.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.Effect_ValueSlider.Location = new System.Drawing.Point(10, 244);
            this.Effect_ValueSlider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Effect_ValueSlider.MaximumValue = 100;
            this.Effect_ValueSlider.Name = "Effect_ValueSlider";
            this.Effect_ValueSlider.Size = new System.Drawing.Size(259, 41);
            this.Effect_ValueSlider.TabIndex = 10;
            this.Effect_ValueSlider.Value = 0;
            // 
            // EffectsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Effect_ValueSlider);
            this.Controls.Add(this.Effects_Label2);
            this.Controls.Add(this.Effects_EffectsComboBox);
            this.Controls.Add(this.Effects_Label1);
            this.Name = "EffectsPanel";
            this.Size = new System.Drawing.Size(298, 322);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Effects_Label1;
        private System.Windows.Forms.ComboBox Effects_EffectsComboBox;
        private System.Windows.Forms.Label Effects_Label2;
        private Bunifu.Framework.UI.BunifuSlider Effect_ValueSlider;
    }
}
