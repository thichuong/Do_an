namespace PaintUI
{
    partial class ColorPanel
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
            this.mainColor = new System.Windows.Forms.PictureBox();
            this.Canvas_Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorBox = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.addColorButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.colorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // mainColor
            // 
            this.mainColor.BackColor = System.Drawing.Color.Black;
            this.mainColor.Location = new System.Drawing.Point(34, 64);
            this.mainColor.Name = "mainColor";
            this.mainColor.Size = new System.Drawing.Size(190, 77);
            this.mainColor.TabIndex = 23;
            this.mainColor.TabStop = false;
            // 
            // Canvas_Label1
            // 
            this.Canvas_Label1.AutoSize = true;
            this.Canvas_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Label1.Location = new System.Drawing.Point(122, 0);
            this.Canvas_Label1.Name = "Canvas_Label1";
            this.Canvas_Label1.Size = new System.Drawing.Size(102, 52);
            this.Canvas_Label1.TabIndex = 24;
            this.Canvas_Label1.Text = "Color";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(51, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 46);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.pictureBox12);
            this.colorBox.Controls.Add(this.pictureBox2);
            this.colorBox.Controls.Add(this.pictureBox11);
            this.colorBox.Controls.Add(this.pictureBox6);
            this.colorBox.Controls.Add(this.pictureBox10);
            this.colorBox.Controls.Add(this.pictureBox5);
            this.colorBox.Controls.Add(this.pictureBox9);
            this.colorBox.Controls.Add(this.pictureBox4);
            this.colorBox.Controls.Add(this.pictureBox8);
            this.colorBox.Controls.Add(this.pictureBox3);
            this.colorBox.Controls.Add(this.pictureBox7);
            this.colorBox.Controls.Add(this.pictureBox1);
            this.colorBox.Location = new System.Drawing.Point(13, 158);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(308, 96);
            this.colorBox.TabIndex = 25;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox12.Location = new System.Drawing.Point(0, 47);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(51, 46);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 46);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Green;
            this.pictureBox11.Location = new System.Drawing.Point(255, 47);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(51, 46);
            this.pictureBox11.TabIndex = 23;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Red;
            this.pictureBox6.Location = new System.Drawing.Point(255, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 46);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Lime;
            this.pictureBox10.Location = new System.Drawing.Point(204, 47);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(51, 46);
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox5.Location = new System.Drawing.Point(204, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 46);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox9.Location = new System.Drawing.Point(153, 47);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(51, 46);
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(153, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 46);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox8.Location = new System.Drawing.Point(102, 46);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(51, 47);
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox3.Location = new System.Drawing.Point(102, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 47);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox7.Location = new System.Drawing.Point(51, 47);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 46);
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // addColorButton
            // 
            this.addColorButton.Activecolor = System.Drawing.Color.Silver;
            this.addColorButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addColorButton.BorderRadius = 0;
            this.addColorButton.ButtonText = "+ Add Color";
            this.addColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addColorButton.DisabledColor = System.Drawing.Color.Gray;
            this.addColorButton.Iconcolor = System.Drawing.Color.Transparent;
            this.addColorButton.Iconimage = global::PaintUI.Properties.Resources.brush4;
            this.addColorButton.Iconimage_right = null;
            this.addColorButton.Iconimage_right_Selected = null;
            this.addColorButton.Iconimage_Selected = null;
            this.addColorButton.IconMarginLeft = 0;
            this.addColorButton.IconMarginRight = 0;
            this.addColorButton.IconRightVisible = true;
            this.addColorButton.IconRightZoom = 0D;
            this.addColorButton.IconVisible = true;
            this.addColorButton.IconZoom = 90D;
            this.addColorButton.IsTab = false;
            this.addColorButton.Location = new System.Drawing.Point(34, 272);
            this.addColorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addColorButton.Name = "addColorButton";
            this.addColorButton.Normalcolor = System.Drawing.Color.Gainsboro;
            this.addColorButton.OnHovercolor = System.Drawing.Color.Silver;
            this.addColorButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.addColorButton.selected = false;
            this.addColorButton.Size = new System.Drawing.Size(255, 63);
            this.addColorButton.TabIndex = 22;
            this.addColorButton.Text = "+ Add Color";
            this.addColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addColorButton.Textcolor = System.Drawing.Color.Black;
            this.addColorButton.TextFont = new System.Drawing.Font("Segoe Print", 12F);
            this.addColorButton.Click += new System.EventHandler(this.addColorButton_Click);
            // 
            // ColorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.Canvas_Label1);
            this.Controls.Add(this.mainColor);
            this.Controls.Add(this.addColorButton);
            this.Name = "ColorPanel";
            this.Size = new System.Drawing.Size(337, 351);
            ((System.ComponentModel.ISupportInitialize)(this.mainColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.colorBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainColor;
        private System.Windows.Forms.Label Canvas_Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel colorBox;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Bunifu.Framework.UI.BunifuFlatButton addColorButton;
    }
}
