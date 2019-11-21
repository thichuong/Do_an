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
    public partial class EffectsPanel : UserControl
    {
        public Color color;
        public EffectsPanel()
        {
            InitializeComponent();
            Effect_ValueSlider.MaximumValue = 12;
            Effect_ValueSlider.Value = 0;
        }
       
        private void Effect_ValueSlider_ValueChanged(object sender, EventArgs e)
        {
            switch(Effect_ValueSlider.Value)
            {
                case 0: color = Color.Transparent;
                    break;
                case 1: color = Color.Gray;
                    break;
                case 2: color = Color.Pink;
                    break;
                case 3: color = Color.Gold;
                    break;
                case 4: color = Color.DarkMagenta;
                    break;
                case 5: color = Color.DarkSeaGreen;
                    break;
                case 6: color = Color.Orchid;
                    break;
                case 7: color = Color.SlateGray;
                    break;
                case 8: color = Color.LightBlue;
                    break;
                case 9: color = Color.Wheat;
                    break;
                case 10: color = Color.DodgerBlue;
                    break;
                case 11: color = Color.DarkRed;
                    break;
                default:
                    color = Color.DarkBlue;
                    break;
            }
            Form1 parent = (Form1)this.ParentForm;
            if(Effect_ValueSlider.Value!=0)
            {
                color = Color.FromArgb(80, color);
                parent.Effect_change(color, Color.FromArgb(255, color));
            }
            else
            {
                parent.Effect_change(color, Color.Gainsboro);
            }
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 9;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 0;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = Color.Transparent;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.Gainsboro);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 2;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 3;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 11;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 5;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 4;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 3;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 10;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 8;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 7;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Effect_ValueSlider.Value = 6;
            PictureBox p = sender as PictureBox;
            Form1 parent = (Form1)this.ParentForm;
            color = p.BackColor;
            color = Color.FromArgb(80, color);
            parent.Effect_change(color, Color.FromArgb(255, color));
        }
    }
}
