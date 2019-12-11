using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace PaintUI
{
    public partial class TextPanel : UserControl
    {

        List<FontFamily> fonts;
        Font textFont;
        float size;
        SolidBrush brush;
        public TextPanel()
        {
            InitializeComponent();
            InitComboBox();
            brush = new SolidBrush(Color.Black);
        }
        private void InitComboBox()
        {
            fonts = new List<FontFamily>();
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                Text_FontCombobox.Items.Add(oneFontFamily.Name);
                fonts.Add(oneFontFamily);
            }
            
            Text_FontCombobox.Text = richTextBox1.Font.Name.ToString();
            for (int i=8;i<40;i+=2)
            {
                Text_SizeComboBox.Items.Add(i);
            }
            Text_FontCombobox.SelectedIndex = 2;
            Text_SizeComboBox.SelectedIndex = 0;
        }

        private void Text_FontCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //size = Convert.ToInt32(Text_SizeComboBox.Text);
            Text_FontCombobox.Font= new Font(fonts[Text_FontCombobox.SelectedIndex],12);
            textFont = new Font(fonts[Text_FontCombobox.SelectedIndex], richTextBox1.Font.Size, FontStyle.Regular);
            richTextBox1.Font = textFont;
        }

        private void Text_SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(Text_SizeComboBox.Text);
            textFont= new Font(richTextBox1.Font.FontFamily, size, FontStyle.Regular);
            richTextBox1.Font = textFont;
        }

        private void Text_FontCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Text_SizeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;

            if(keycode < 48 || keycode > 57)
            {
                e.Handled = true;
            }
        }
        public void DrawText(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size)
        {
            
            g.DrawString(richTextBox1.Text, richTextBox1.Font, brush, cur.X, cur.Y);
        }
        private void addColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                    mainColor1.BackColor = cld.Color;
            }
        }

        private void mainColor1_BackColorChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(mainColor1.BackColor);
            richTextBox1.ForeColor = brush.Color;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox colorCell = sender as PictureBox;
            mainColor1.BackColor = colorCell.BackColor;
        }
    }
}
