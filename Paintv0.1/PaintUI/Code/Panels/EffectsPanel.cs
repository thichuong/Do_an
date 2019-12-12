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
        public Color color,color2;
        int value;
        public EffectsPanel()
        {
            InitializeComponent();
            Effect_ValueSlider.MaximumValue = 30;
            Effect_ValueSlider.Value = 0;
            value = 0;
        }
       
        private void Effect_ValueSlider_ValueChanged(object sender, EventArgs e)
        {

            Form1 parent = (Form1)this.ParentForm;
            if(value!=0)
            {
                color = Color.FromArgb(70 + Effect_ValueSlider.Value, color2);
                parent.Effect_change(color, color2);
            }
            else
            {
                color = Color.FromArgb(0 + Effect_ValueSlider.Value*2, Color.Transparent);
                parent.Effect_change(color, color2);
            }
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            value = 0;
            PictureBox p = sender as PictureBox;
            color = Color.Transparent;
            color2 = Color.Silver;
            Form1 parent = (Form1)this.ParentForm;
            parent.Effect_change(color, color2);
            Effect_ValueSlider.Value = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            value = 1;
            PictureBox p = sender as PictureBox;
            color2 = p.BackColor;
            color = Color.FromArgb(70, color2);
            Form1 parent = (Form1)this.ParentForm;
            parent.Effect_change(color, color2);
            Effect_ValueSlider.Value = 0;
        }

     
    }
}
