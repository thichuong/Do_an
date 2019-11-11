namespace PaintUI
{
    partial class TextPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Text_SizeComboBox = new System.Windows.Forms.ComboBox();
            this.Text_FontCombobox = new System.Windows.Forms.ComboBox();
            this.Text_Label2 = new System.Windows.Forms.Label();
            this.Text_Label1 = new System.Windows.Forms.Label();
            this.Text_CreateTextBoxButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Text_SizeComboBox);
            this.panel1.Controls.Add(this.Text_FontCombobox);
            this.panel1.Controls.Add(this.Text_Label2);
            this.panel1.Controls.Add(this.Text_CreateTextBoxButton);
            this.panel1.Controls.Add(this.Text_Label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(300, 551);
            this.panel1.TabIndex = 3;
            // 
            // Text_SizeComboBox
            // 
            this.Text_SizeComboBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Text_SizeComboBox.FormattingEnabled = true;
            this.Text_SizeComboBox.Location = new System.Drawing.Point(40, 310);
            this.Text_SizeComboBox.Name = "Text_SizeComboBox";
            this.Text_SizeComboBox.Size = new System.Drawing.Size(230, 43);
            this.Text_SizeComboBox.TabIndex = 4;
            // 
            // Text_FontCombobox
            // 
            this.Text_FontCombobox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Text_FontCombobox.FormattingEnabled = true;
            this.Text_FontCombobox.Location = new System.Drawing.Point(40, 180);
            this.Text_FontCombobox.Name = "Text_FontCombobox";
            this.Text_FontCombobox.Size = new System.Drawing.Size(230, 43);
            this.Text_FontCombobox.TabIndex = 3;
            // 
            // Text_Label2
            // 
            this.Text_Label2.AutoSize = true;
            this.Text_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Text_Label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Label2.Location = new System.Drawing.Point(40, 250);
            this.Text_Label2.Name = "Text_Label2";
            this.Text_Label2.Size = new System.Drawing.Size(68, 43);
            this.Text_Label2.TabIndex = 2;
            this.Text_Label2.Text = "Size";
            // 
            // Text_Label1
            // 
            this.Text_Label1.AutoSize = true;
            this.Text_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Text_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Label1.Location = new System.Drawing.Point(40, 120);
            this.Text_Label1.Name = "Text_Label1";
            this.Text_Label1.Size = new System.Drawing.Size(77, 43);
            this.Text_Label1.TabIndex = 0;
            this.Text_Label1.Text = "Font";
            // 
            // Text_CreateTextBoxButton
            // 
            this.Text_CreateTextBoxButton.Activecolor = System.Drawing.Color.Transparent;
            this.Text_CreateTextBoxButton.BackColor = System.Drawing.Color.Gainsboro;
            this.Text_CreateTextBoxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Text_CreateTextBoxButton.BorderRadius = 0;
            this.Text_CreateTextBoxButton.ButtonText = "Create TextBox        ";
            this.Text_CreateTextBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Text_CreateTextBoxButton.DisabledColor = System.Drawing.Color.Gray;
            this.Text_CreateTextBoxButton.Iconcolor = System.Drawing.Color.Transparent;
            this.Text_CreateTextBoxButton.Iconimage = global::PaintUI.Properties.Resources.create;
            this.Text_CreateTextBoxButton.Iconimage_right = null;
            this.Text_CreateTextBoxButton.Iconimage_right_Selected = null;
            this.Text_CreateTextBoxButton.Iconimage_Selected = null;
            this.Text_CreateTextBoxButton.IconMarginLeft = 0;
            this.Text_CreateTextBoxButton.IconMarginRight = 0;
            this.Text_CreateTextBoxButton.IconRightVisible = true;
            this.Text_CreateTextBoxButton.IconRightZoom = 0D;
            this.Text_CreateTextBoxButton.IconVisible = true;
            this.Text_CreateTextBoxButton.IconZoom = 70D;
            this.Text_CreateTextBoxButton.IsTab = false;
            this.Text_CreateTextBoxButton.Location = new System.Drawing.Point(40, 40);
            this.Text_CreateTextBoxButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_CreateTextBoxButton.Name = "Text_CreateTextBoxButton";
            this.Text_CreateTextBoxButton.Normalcolor = System.Drawing.Color.Gainsboro;
            this.Text_CreateTextBoxButton.OnHovercolor = System.Drawing.Color.Silver;
            this.Text_CreateTextBoxButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.Text_CreateTextBoxButton.selected = false;
            this.Text_CreateTextBoxButton.Size = new System.Drawing.Size(230, 50);
            this.Text_CreateTextBoxButton.TabIndex = 1;
            this.Text_CreateTextBoxButton.Text = "Create TextBox        ";
            this.Text_CreateTextBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Text_CreateTextBoxButton.Textcolor = System.Drawing.Color.Black;
            this.Text_CreateTextBoxButton.TextFont = new System.Drawing.Font("Segoe Print", 10F);
            // 
            // TextPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TextPanel";
            this.Size = new System.Drawing.Size(300, 551);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Text_SizeComboBox;
        private System.Windows.Forms.ComboBox Text_FontCombobox;
        private System.Windows.Forms.Label Text_Label2;
        private Bunifu.Framework.UI.BunifuFlatButton Text_CreateTextBoxButton;
        private System.Windows.Forms.Label Text_Label1;
    }
}
