namespace PaintUI
{
    partial class LayerPanel
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
            this.AddButton = new System.Windows.Forms.Button();
            this.BaseLayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 30);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BaseLayer
            // 
            this.BaseLayer.BackColor = System.Drawing.Color.White;
            this.BaseLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseLayer.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BaseLayer.Location = new System.Drawing.Point(0, 30);
            this.BaseLayer.Name = "BaseLayer";
            this.BaseLayer.Size = new System.Drawing.Size(60, 30);
            this.BaseLayer.TabIndex = 1;
            this.BaseLayer.Text = "Base";
            this.BaseLayer.UseVisualStyleBackColor = false;
            this.BaseLayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseLayer_MouseDown);
            // 
            // LayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.BaseLayer);
            this.Controls.Add(this.AddButton);
            this.Name = "LayerPanel";
            this.Size = new System.Drawing.Size(60, 369);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button BaseLayer;
    }
}
