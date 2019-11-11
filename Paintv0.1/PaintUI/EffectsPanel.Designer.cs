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
            this.EffectsPanel1 = new System.Windows.Forms.Panel();
            this.Effect_ValueSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.Effects_Label2 = new System.Windows.Forms.Label();
            this.Effects_EffectsComboBox = new System.Windows.Forms.ComboBox();
            this.Effects_Label1 = new System.Windows.Forms.Label();
            this.EffectsPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EffectsPanel1
            // 
            this.EffectsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EffectsPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.EffectsPanel1.Controls.Add(this.Effect_ValueSlider);
            this.EffectsPanel1.Controls.Add(this.Effects_Label2);
            this.EffectsPanel1.Controls.Add(this.Effects_EffectsComboBox);
            this.EffectsPanel1.Controls.Add(this.Effects_Label1);
            this.EffectsPanel1.Location = new System.Drawing.Point(0, 0);
            this.EffectsPanel1.Name = "EffectsPanel1";
            this.EffectsPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EffectsPanel1.Size = new System.Drawing.Size(300, 551);
            this.EffectsPanel1.TabIndex = 12;
            // 
            // Effect_ValueSlider
            // 
            this.Effect_ValueSlider.BackColor = System.Drawing.Color.Transparent;
            this.Effect_ValueSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Effect_ValueSlider.BorderRadius = 0;
            this.Effect_ValueSlider.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.Effect_ValueSlider.Location = new System.Drawing.Point(40, 260);
            this.Effect_ValueSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Effect_ValueSlider.MaximumValue = 100;
            this.Effect_ValueSlider.Name = "Effect_ValueSlider";
            this.Effect_ValueSlider.Size = new System.Drawing.Size(230, 35);
            this.Effect_ValueSlider.TabIndex = 9;
            this.Effect_ValueSlider.Value = 0;
            // 
            // Effects_Label2
            // 
            this.Effects_Label2.AutoSize = true;
            this.Effects_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Effects_Label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Effects_Label2.Location = new System.Drawing.Point(40, 200);
            this.Effects_Label2.Name = "Effects_Label2";
            this.Effects_Label2.Size = new System.Drawing.Size(87, 43);
            this.Effects_Label2.TabIndex = 5;
            this.Effects_Label2.Text = "Value";
            // 
            // Effects_EffectsComboBox
            // 
            this.Effects_EffectsComboBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Effects_EffectsComboBox.FormattingEnabled = true;
            this.Effects_EffectsComboBox.Location = new System.Drawing.Point(40, 100);
            this.Effects_EffectsComboBox.Name = "Effects_EffectsComboBox";
            this.Effects_EffectsComboBox.Size = new System.Drawing.Size(230, 43);
            this.Effects_EffectsComboBox.TabIndex = 3;
            // 
            // Effects_Label1
            // 
            this.Effects_Label1.AutoSize = true;
            this.Effects_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Effects_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Effects_Label1.Location = new System.Drawing.Point(40, 40);
            this.Effects_Label1.Name = "Effects_Label1";
            this.Effects_Label1.Size = new System.Drawing.Size(103, 43);
            this.Effects_Label1.TabIndex = 0;
            this.Effects_Label1.Text = "Effects";
            // 
            // EffectsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EffectsPanel1);
            this.Name = "EffectsPanel";
            this.Size = new System.Drawing.Size(300, 551);
            this.EffectsPanel1.ResumeLayout(false);
            this.EffectsPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EffectsPanel1;
        private Bunifu.Framework.UI.BunifuSlider Effect_ValueSlider;
        private System.Windows.Forms.Label Effects_Label2;
        private System.Windows.Forms.ComboBox Effects_EffectsComboBox;
        private System.Windows.Forms.Label Effects_Label1;
    }
}
