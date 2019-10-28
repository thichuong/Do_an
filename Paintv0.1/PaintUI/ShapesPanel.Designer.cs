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
            this.starButton = new System.Windows.Forms.Button();
            this.arrowButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.lightningButton = new System.Windows.Forms.Button();
            this.hexagonButton = new System.Windows.Forms.Button();
            this.iso_triangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Shapes_OutlineCheckBox
            // 
            this.Shapes_OutlineCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Shapes_OutlineCheckBox.Checked = true;
            this.Shapes_OutlineCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ForeColor = System.Drawing.Color.White;
            this.Shapes_OutlineCheckBox.Location = new System.Drawing.Point(213, 505);
            this.Shapes_OutlineCheckBox.Margin = new System.Windows.Forms.Padding(9, 14, 9, 14);
            this.Shapes_OutlineCheckBox.Name = "Shapes_OutlineCheckBox";
            this.Shapes_OutlineCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Shapes_OutlineCheckBox.TabIndex = 16;
            this.Shapes_OutlineCheckBox.OnChange += new System.EventHandler(this.Shapes_OutlineCheckBox_OnChange);
            // 
            // Shapes_Label4
            // 
            this.Shapes_Label4.AutoSize = true;
            this.Shapes_Label4.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label4.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label4.Location = new System.Drawing.Point(57, 487);
            this.Shapes_Label4.Name = "Shapes_Label4";
            this.Shapes_Label4.Size = new System.Drawing.Size(133, 52);
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
            this.Shapes_FillCheckBox.Location = new System.Drawing.Point(213, 433);
            this.Shapes_FillCheckBox.Margin = new System.Windows.Forms.Padding(9, 14, 9, 14);
            this.Shapes_FillCheckBox.Name = "Shapes_FillCheckBox";
            this.Shapes_FillCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Shapes_FillCheckBox.TabIndex = 14;
            this.Shapes_FillCheckBox.OnChange += new System.EventHandler(this.Shapes_FillCheckBox_OnChange);
            // 
            // Shapes_Label3
            // 
            this.Shapes_Label3.AutoSize = true;
            this.Shapes_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label3.Location = new System.Drawing.Point(75, 414);
            this.Shapes_Label3.Name = "Shapes_Label3";
            this.Shapes_Label3.Size = new System.Drawing.Size(68, 52);
            this.Shapes_Label3.TabIndex = 13;
            this.Shapes_Label3.Text = "Fill";
            // 
            // Shapes_Label1
            // 
            this.Shapes_Label1.AutoSize = true;
            this.Shapes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Shapes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shapes_Label1.Location = new System.Drawing.Point(101, 14);
            this.Shapes_Label1.Name = "Shapes_Label1";
            this.Shapes_Label1.Size = new System.Drawing.Size(127, 52);
            this.Shapes_Label1.TabIndex = 9;
            this.Shapes_Label1.Text = "Shapes";
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(32, 85);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(76, 75);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Location = new System.Drawing.Point(132, 85);
            this.ellipseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(76, 75);
            this.ellipseButton.TabIndex = 0;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(233, 85);
            this.lineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(76, 75);
            this.lineButton.TabIndex = 0;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // starButton
            // 
            this.starButton.Location = new System.Drawing.Point(233, 186);
            this.starButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(76, 75);
            this.starButton.TabIndex = 0;
            this.starButton.Text = "Star";
            this.starButton.UseVisualStyleBackColor = true;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // arrowButton
            // 
            this.arrowButton.Location = new System.Drawing.Point(32, 287);
            this.arrowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrowButton.Name = "arrowButton";
            this.arrowButton.Size = new System.Drawing.Size(76, 75);
            this.arrowButton.TabIndex = 0;
            this.arrowButton.Text = "Arrow";
            this.arrowButton.UseVisualStyleBackColor = true;
            this.arrowButton.Click += new System.EventHandler(this.arrowButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(132, 287);
            this.triangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(76, 75);
            this.triangleButton.TabIndex = 0;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // lightningButton
            // 
            this.lightningButton.Location = new System.Drawing.Point(233, 287);
            this.lightningButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lightningButton.Name = "lightningButton";
            this.lightningButton.Size = new System.Drawing.Size(76, 75);
            this.lightningButton.TabIndex = 0;
            this.lightningButton.Text = "Lightning";
            this.lightningButton.UseVisualStyleBackColor = true;
            this.lightningButton.Click += new System.EventHandler(this.lightningButton_Click);
            // 
            // hexagonButton
            // 
            this.hexagonButton.Location = new System.Drawing.Point(32, 186);
            this.hexagonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hexagonButton.Name = "hexagonButton";
            this.hexagonButton.Size = new System.Drawing.Size(76, 75);
            this.hexagonButton.TabIndex = 0;
            this.hexagonButton.Text = "Hexagon";
            this.hexagonButton.UseVisualStyleBackColor = true;
            this.hexagonButton.Click += new System.EventHandler(this.hexagonButton_Click);
            // 
            // iso_triangleButton
            // 
            this.iso_triangleButton.Location = new System.Drawing.Point(132, 186);
            this.iso_triangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iso_triangleButton.Name = "iso_triangleButton";
            this.iso_triangleButton.Size = new System.Drawing.Size(76, 75);
            this.iso_triangleButton.TabIndex = 0;
            this.iso_triangleButton.Text = "IsoTriangle";
            this.iso_triangleButton.UseVisualStyleBackColor = true;
            this.iso_triangleButton.Click += new System.EventHandler(this.iso_triangleButton_Click);
            // 
            // ShapesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lightningButton);
            this.Controls.Add(this.iso_triangleButton);
            this.Controls.Add(this.hexagonButton);
            this.Controls.Add(this.starButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.arrowButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.Shapes_OutlineCheckBox);
            this.Controls.Add(this.Shapes_Label4);
            this.Controls.Add(this.Shapes_FillCheckBox);
            this.Controls.Add(this.Shapes_Label3);
            this.Controls.Add(this.Shapes_Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShapesPanel";
            this.Size = new System.Drawing.Size(338, 564);
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
        private System.Windows.Forms.Button starButton;
        private System.Windows.Forms.Button arrowButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button lightningButton;
        private System.Windows.Forms.Button hexagonButton;
        private System.Windows.Forms.Button iso_triangleButton;
    }
}
