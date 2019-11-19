namespace PaintUI
{
    partial class CanvasPanel
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
            this.Canvas_Label2 = new System.Windows.Forms.Label();
            this.Canvas_Label3 = new System.Windows.Forms.Label();
            this.Canvas_TransparentCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.CanvasLabel5 = new System.Windows.Forms.Label();
            this.Canvas_ShowCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Canvas_Label4 = new System.Windows.Forms.Label();
            this.Canvas_Label1 = new System.Windows.Forms.Label();
            this.Canvas_Width = new System.Windows.Forms.TextBox();
            this.Canvas_Height = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Canvas_Label2
            // 
            this.Canvas_Label2.AutoSize = true;
            this.Canvas_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label2.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Canvas_Label2.Location = new System.Drawing.Point(42, 61);
            this.Canvas_Label2.Name = "Canvas_Label2";
            this.Canvas_Label2.Size = new System.Drawing.Size(65, 30);
            this.Canvas_Label2.TabIndex = 19;
            this.Canvas_Label2.Text = "Width";
            // 
            // Canvas_Label3
            // 
            this.Canvas_Label3.AutoSize = true;
            this.Canvas_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label3.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Canvas_Label3.Location = new System.Drawing.Point(162, 61);
            this.Canvas_Label3.Name = "Canvas_Label3";
            this.Canvas_Label3.Size = new System.Drawing.Size(70, 30);
            this.Canvas_Label3.TabIndex = 18;
            this.Canvas_Label3.Text = "Height";
            // 
            // Canvas_TransparentCheckBox
            // 
            this.Canvas_TransparentCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Canvas_TransparentCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Canvas_TransparentCheckBox.Checked = true;
            this.Canvas_TransparentCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Canvas_TransparentCheckBox.ForeColor = System.Drawing.Color.White;
            this.Canvas_TransparentCheckBox.Location = new System.Drawing.Point(235, 245);
            this.Canvas_TransparentCheckBox.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Canvas_TransparentCheckBox.Name = "Canvas_TransparentCheckBox";
            this.Canvas_TransparentCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Canvas_TransparentCheckBox.TabIndex = 17;
            this.Canvas_TransparentCheckBox.OnChange += new System.EventHandler(this.Canvas_TransparentCheckBox_OnChange);
            // 
            // CanvasLabel5
            // 
            this.CanvasLabel5.AutoSize = true;
            this.CanvasLabel5.BackColor = System.Drawing.Color.Transparent;
            this.CanvasLabel5.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanvasLabel5.Location = new System.Drawing.Point(25, 226);
            this.CanvasLabel5.Name = "CanvasLabel5";
            this.CanvasLabel5.Size = new System.Drawing.Size(178, 43);
            this.CanvasLabel5.TabIndex = 16;
            this.CanvasLabel5.Text = "Transparent";
            // 
            // Canvas_ShowCheckBox
            // 
            this.Canvas_ShowCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Canvas_ShowCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Canvas_ShowCheckBox.Checked = true;
            this.Canvas_ShowCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Canvas_ShowCheckBox.ForeColor = System.Drawing.Color.White;
            this.Canvas_ShowCheckBox.Location = new System.Drawing.Point(235, 186);
            this.Canvas_ShowCheckBox.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Canvas_ShowCheckBox.Name = "Canvas_ShowCheckBox";
            this.Canvas_ShowCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Canvas_ShowCheckBox.TabIndex = 15;
            this.Canvas_ShowCheckBox.OnChange += new System.EventHandler(this.Canvas_ShowCheckBox_OnChange);
            // 
            // Canvas_Label4
            // 
            this.Canvas_Label4.AutoSize = true;
            this.Canvas_Label4.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label4.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Label4.Location = new System.Drawing.Point(25, 170);
            this.Canvas_Label4.Name = "Canvas_Label4";
            this.Canvas_Label4.Size = new System.Drawing.Size(87, 43);
            this.Canvas_Label4.TabIndex = 14;
            this.Canvas_Label4.Text = "Show";
            // 
            // Canvas_Label1
            // 
            this.Canvas_Label1.AutoSize = true;
            this.Canvas_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Label1.Location = new System.Drawing.Point(98, 7);
            this.Canvas_Label1.Name = "Canvas_Label1";
            this.Canvas_Label1.Size = new System.Drawing.Size(68, 43);
            this.Canvas_Label1.TabIndex = 11;
            this.Canvas_Label1.Text = "Size";
            // 
            // Canvas_Width
            // 
            this.Canvas_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Width.Location = new System.Drawing.Point(35, 111);
            this.Canvas_Width.Name = "Canvas_Width";
            this.Canvas_Width.Size = new System.Drawing.Size(77, 34);
            this.Canvas_Width.TabIndex = 24;
            this.Canvas_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Canvas_Width.Click += new System.EventHandler(this._Click);
            this.Canvas_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Canvas_textBoxKeypress);
            // 
            // Canvas_Height
            // 
            this.Canvas_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Height.Location = new System.Drawing.Point(155, 111);
            this.Canvas_Height.Name = "Canvas_Height";
            this.Canvas_Height.Size = new System.Drawing.Size(77, 34);
            this.Canvas_Height.TabIndex = 25;
            this.Canvas_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Canvas_Height.Click += new System.EventHandler(this._Click);
            this.Canvas_Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Canvas_textBoxKeypress);
            // 
            // CanvasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.Canvas_Height);
            this.Controls.Add(this.Canvas_Width);
            this.Controls.Add(this.Canvas_Label2);
            this.Controls.Add(this.Canvas_Label3);
            this.Controls.Add(this.Canvas_TransparentCheckBox);
            this.Controls.Add(this.CanvasLabel5);
            this.Controls.Add(this.Canvas_ShowCheckBox);
            this.Controls.Add(this.Canvas_Label4);
            this.Controls.Add(this.Canvas_Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CanvasPanel";
            this.Size = new System.Drawing.Size(287, 302);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Canvas_Label2;
        private System.Windows.Forms.Label Canvas_Label3;
        private Bunifu.Framework.UI.BunifuCheckbox Canvas_TransparentCheckBox;
        private System.Windows.Forms.Label CanvasLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox Canvas_ShowCheckBox;
        private System.Windows.Forms.Label Canvas_Label4;
        private System.Windows.Forms.Label Canvas_Label1;
        private System.Windows.Forms.TextBox Canvas_Width;
        private System.Windows.Forms.TextBox Canvas_Height;
    }
}
