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
            this.Shapes_OutlineCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Shapes_Label4 = new System.Windows.Forms.Label();
            this.Shapes_FillCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Shapes_Label3 = new System.Windows.Forms.Label();
            this.Shapes_Label1 = new System.Windows.Forms.Label();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.thicknessSlide = new Bunifu.Framework.UI.BunifuSlider();
            this.Brushes_Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Shapes_OutlineCheckBox
            // 
            this.Shapes_OutlineCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Shapes_OutlineCheckBox.Checked = true;
            this.Shapes_OutlineCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ForeColor = System.Drawing.Color.White;
            this.Shapes_OutlineCheckBox.Location = new System.Drawing.Point(158, 242);
            this.Shapes_OutlineCheckBox.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Shapes_OutlineCheckBox.Name = "Shapes_OutlineCheckBox";
            this.Shapes_OutlineCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Shapes_OutlineCheckBox.TabIndex = 16;
            // 
            // Shapes_Label4
            // 
            this.Shapes_Label4.AutoSize = true;
            this.Shapes_Label4.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label4.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label4.Location = new System.Drawing.Point(20, 227);
            this.Shapes_Label4.Name = "Shapes_Label4";
            this.Shapes_Label4.Size = new System.Drawing.Size(110, 43);
            this.Shapes_Label4.TabIndex = 15;
            this.Shapes_Label4.Text = "Outline";
            // 
            // Shapes_FillCheckBox
            // 
            this.Shapes_FillCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Shapes_FillCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Shapes_FillCheckBox.Checked = true;
            this.Shapes_FillCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Shapes_FillCheckBox.ForeColor = System.Drawing.Color.White;
            this.Shapes_FillCheckBox.Location = new System.Drawing.Point(158, 184);
            this.Shapes_FillCheckBox.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Shapes_FillCheckBox.Name = "Shapes_FillCheckBox";
            this.Shapes_FillCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Shapes_FillCheckBox.TabIndex = 14;
            // 
            // Shapes_Label3
            // 
            this.Shapes_Label3.AutoSize = true;
            this.Shapes_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label3.Location = new System.Drawing.Point(36, 169);
            this.Shapes_Label3.Name = "Shapes_Label3";
            this.Shapes_Label3.Size = new System.Drawing.Size(55, 43);
            this.Shapes_Label3.TabIndex = 13;
            this.Shapes_Label3.Text = "Fill";
            // 
            // Shapes_Label1
            // 
            this.Shapes_Label1.AutoSize = true;
            this.Shapes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label1.Location = new System.Drawing.Point(90, 11);
            this.Shapes_Label1.Name = "Shapes_Label1";
            this.Shapes_Label1.Size = new System.Drawing.Size(106, 43);
            this.Shapes_Label1.TabIndex = 9;
            this.Shapes_Label1.Text = "Shapes";
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(28, 68);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(68, 60);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Location = new System.Drawing.Point(117, 68);
            this.ellipseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(68, 60);
            this.ellipseButton.TabIndex = 0;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(207, 68);
            this.lineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(68, 60);
            this.lineButton.TabIndex = 0;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // thicknessSlide
            // 
            this.thicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.thicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.thicknessSlide.BorderRadius = 0;
            this.thicknessSlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.thicknessSlide.Location = new System.Drawing.Point(28, 355);
            this.thicknessSlide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thicknessSlide.MaximumValue = 100;
            this.thicknessSlide.Name = "thicknessSlide";
            this.thicknessSlide.Size = new System.Drawing.Size(230, 35);
            this.thicknessSlide.TabIndex = 20;
            this.thicknessSlide.Value = 0;
            this.thicknessSlide.ValueChanged += new System.EventHandler(this.thicknessSlide_ValueChanged);
            // 
            // Brushes_Label2
            // 
            this.Brushes_Label2.AutoSize = true;
            this.Brushes_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Brushes_Label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brushes_Label2.Location = new System.Drawing.Point(20, 293);
            this.Brushes_Label2.Name = "Brushes_Label2";
            this.Brushes_Label2.Size = new System.Drawing.Size(139, 43);
            this.Brushes_Label2.TabIndex = 19;
            this.Brushes_Label2.Text = "Thickness";
            // 
            // ShapesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.thicknessSlide);
            this.Controls.Add(this.Brushes_Label2);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.Shapes_OutlineCheckBox);
            this.Controls.Add(this.Shapes_Label4);
            this.Controls.Add(this.Shapes_FillCheckBox);
            this.Controls.Add(this.Shapes_Label3);
            this.Controls.Add(this.Shapes_Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShapesPanel";
            this.Size = new System.Drawing.Size(300, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox Shapes_OutlineCheckBox;
        private System.Windows.Forms.Label Shapes_Label4;
        private Bunifu.Framework.UI.BunifuCheckbox Shapes_FillCheckBox;
        private System.Windows.Forms.Label Shapes_Label3;
        private System.Windows.Forms.Label Shapes_Label1;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button lineButton;
        private Bunifu.Framework.UI.BunifuSlider thicknessSlide;
        private System.Windows.Forms.Label Brushes_Label2;
    }
}
