using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI
{
    public partial class ColorPanel : UserControl
    {
        int select;
        private bool pickerActive;
        public event EventHandler StateChanged;
        public ColorPanel()
        {
            InitializeComponent();

            mainColor1.BringToFront();
            select = 1;
            pickerActive = false;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox colorCell = sender as PictureBox;
            if (select == 1)
            {
                mainColor1.BackColor = colorCell.BackColor;
            }
            else
            {
                mainColor2.BackColor = colorCell.BackColor;
            }
        }

        private void addColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                if(select==1)
                {
                    mainColor1.BackColor = cld.Color;
                }
                else
                {
                    mainColor2.BackColor = cld.Color;
                }
            }
        }

        public Color getColor1()
        {
            return mainColor1.BackColor;
        }

        public Color getColor2()
        {
            return mainColor2.BackColor;
        }

        private void mainColor1_Click(object sender, EventArgs e)
        {
            PictureBox color = sender as PictureBox;
            color.BorderStyle = BorderStyle.Fixed3D;
            mainColor2.BorderStyle = BorderStyle.FixedSingle;
            select = 1;
        }

        private void mainColor2_Click(object sender, EventArgs e)
        {
            PictureBox color = sender as PictureBox;
            color.BorderStyle = BorderStyle.Fixed3D;
            mainColor1.BorderStyle = BorderStyle.FixedSingle;
            select = 2;
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            pickerActive = !pickerActive;
            if (pickerActive)
            {
                p.BackColor = Color.Cyan;
            }
            else
            {
                p.BackColor = Color.Transparent;
            }

            if (this.StateChanged != null)
                this.StateChanged(this, e);
        }

        public void getPixelColor(Bitmap bm, Point cur)
        {
            Color c = bm.GetPixel(cur.X, cur.Y);
            if(select == 1)
            {
                mainColor1.BackColor = c;
            }
            else
            {
                mainColor2.BackColor = c;
            }
            pickerActive = !pickerActive;
            if (pickerActive)
            {
                colorPicker.BackColor = Color.Cyan;
            }
            else
            {
                colorPicker.BackColor = Color.Transparent;
            }
        }
        
    }
}
