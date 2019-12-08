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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.Canvas_Height = new System.Windows.Forms.TextBox();
            this.Canvas_Width = new System.Windows.Forms.TextBox();
            this.Canvas_Label2 = new System.Windows.Forms.Label();
            this.Canvas_Label3 = new System.Windows.Forms.Label();
            this.Canvas_TransparentCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.CanvasLabel5 = new System.Windows.Forms.Label();
            this.Canvas_ShowCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Canvas_Label4 = new System.Windows.Forms.Label();
            this.Canvas_Label1 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.Canvas_Height);
            this.bunifuCards1.Controls.Add(this.Canvas_Width);
            this.bunifuCards1.Controls.Add(this.Canvas_Label2);
            this.bunifuCards1.Controls.Add(this.Canvas_Label3);
            this.bunifuCards1.Controls.Add(this.Canvas_TransparentCheckBox);
            this.bunifuCards1.Controls.Add(this.CanvasLabel5);
            this.bunifuCards1.Controls.Add(this.Canvas_ShowCheckBox);
            this.bunifuCards1.Controls.Add(this.Canvas_Label4);
            this.bunifuCards1.Controls.Add(this.Canvas_Label1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(323, 378);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Click += new System.EventHandler(this._Click);
            this.bunifuCards1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            // 
            // Canvas_Height
            // 
            this.Canvas_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Height.Location = new System.Drawing.Point(179, 158);
            this.Canvas_Height.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Canvas_Height.Name = "Canvas_Height";
            this.Canvas_Height.Size = new System.Drawing.Size(86, 39);
            this.Canvas_Height.TabIndex = 34;
            this.Canvas_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Canvas_Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Canvas_textBoxKeypress);
            // 
            // Canvas_Width
            // 
            this.Canvas_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Width.Location = new System.Drawing.Point(44, 158);
            this.Canvas_Width.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Canvas_Width.Name = "Canvas_Width";
            this.Canvas_Width.Size = new System.Drawing.Size(86, 39);
            this.Canvas_Width.TabIndex = 33;
            this.Canvas_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Canvas_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Canvas_textBoxKeypress);
            // 
            // Canvas_Label2
            // 
            this.Canvas_Label2.AutoSize = true;
            this.Canvas_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label2.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Canvas_Label2.Location = new System.Drawing.Point(52, 94);
            this.Canvas_Label2.Name = "Canvas_Label2";
            this.Canvas_Label2.Size = new System.Drawing.Size(76, 35);
            this.Canvas_Label2.TabIndex = 32;
            this.Canvas_Label2.Text = "Width";
            // 
            // Canvas_Label3
            // 
            this.Canvas_Label3.AutoSize = true;
            this.Canvas_Label3.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label3.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Canvas_Label3.Location = new System.Drawing.Point(187, 94);
            this.Canvas_Label3.Name = "Canvas_Label3";
            this.Canvas_Label3.Size = new System.Drawing.Size(80, 35);
            this.Canvas_Label3.TabIndex = 31;
            this.Canvas_Label3.Text = "Height";
            // 
            // Canvas_TransparentCheckBox
            // 
            this.Canvas_TransparentCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Canvas_TransparentCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Canvas_TransparentCheckBox.Checked = true;
            this.Canvas_TransparentCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Canvas_TransparentCheckBox.ForeColor = System.Drawing.Color.White;
            this.Canvas_TransparentCheckBox.Location = new System.Drawing.Point(269, 324);
            this.Canvas_TransparentCheckBox.Margin = new System.Windows.Forms.Padding(9, 14, 9, 14);
            this.Canvas_TransparentCheckBox.Name = "Canvas_TransparentCheckBox";
            this.Canvas_TransparentCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Canvas_TransparentCheckBox.TabIndex = 30;
            this.Canvas_TransparentCheckBox.OnChange += new System.EventHandler(this.Canvas_TransparentCheckBox_OnChange);
            // 
            // CanvasLabel5
            // 
            this.CanvasLabel5.AutoSize = true;
            this.CanvasLabel5.BackColor = System.Drawing.Color.Transparent;
            this.CanvasLabel5.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanvasLabel5.Location = new System.Drawing.Point(33, 300);
            this.CanvasLabel5.Name = "CanvasLabel5";
            this.CanvasLabel5.Size = new System.Drawing.Size(211, 52);
            this.CanvasLabel5.TabIndex = 29;
            this.CanvasLabel5.Text = "Transparent";
            // 
            // Canvas_ShowCheckBox
            // 
            this.Canvas_ShowCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Canvas_ShowCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Canvas_ShowCheckBox.Checked = true;
            this.Canvas_ShowCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.Canvas_ShowCheckBox.ForeColor = System.Drawing.Color.White;
            this.Canvas_ShowCheckBox.Location = new System.Drawing.Point(269, 250);
            this.Canvas_ShowCheckBox.Margin = new System.Windows.Forms.Padding(9, 14, 9, 14);
            this.Canvas_ShowCheckBox.Name = "Canvas_ShowCheckBox";
            this.Canvas_ShowCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Canvas_ShowCheckBox.TabIndex = 28;
            this.Canvas_ShowCheckBox.OnChange += new System.EventHandler(this.Canvas_ShowCheckBox_OnChange);
            // 
            // Canvas_Label4
            // 
            this.Canvas_Label4.AutoSize = true;
            this.Canvas_Label4.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label4.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Label4.Location = new System.Drawing.Point(33, 230);
            this.Canvas_Label4.Name = "Canvas_Label4";
            this.Canvas_Label4.Size = new System.Drawing.Size(104, 52);
            this.Canvas_Label4.TabIndex = 27;
            this.Canvas_Label4.Text = "Show";
            // 
            // Canvas_Label1
            // 
            this.Canvas_Label1.AutoSize = true;
            this.Canvas_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Label1.Location = new System.Drawing.Point(100, 30);
            this.Canvas_Label1.Name = "Canvas_Label1";
            this.Canvas_Label1.Size = new System.Drawing.Size(82, 52);
            this.Canvas_Label1.TabIndex = 26;
            this.Canvas_Label1.Text = "Size";
            // 
            // CanvasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bunifuCards1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CanvasPanel";
            this.Size = new System.Drawing.Size(323, 378);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.TextBox Canvas_Height;
        private System.Windows.Forms.TextBox Canvas_Width;
        private System.Windows.Forms.Label Canvas_Label2;
        private System.Windows.Forms.Label Canvas_Label3;
        private Bunifu.Framework.UI.BunifuCheckbox Canvas_TransparentCheckBox;
        private System.Windows.Forms.Label CanvasLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox Canvas_ShowCheckBox;
        private System.Windows.Forms.Label Canvas_Label4;
        private System.Windows.Forms.Label Canvas_Label1;
    }
}
