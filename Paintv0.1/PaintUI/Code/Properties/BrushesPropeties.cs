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
    public partial class BrushesPropeties : UserControl
    {
        public BrushesPropeties()
        {
            InitializeComponent();
            ThicknessSlide.Value = 5;
            OpacitySlide.Value = 255;
            ThicknessSlide.MaximumValue = 30;

            ThicknessTb.Text = ThicknessSlide.Value.ToString();
            OpacityTb.Text = OpacitySlide.Value.ToString();
        }
        
        public int Thickness
        {
            get { return ThicknessSlide.Value; }
            set { ThicknessSlide.Value = value; }
        }

        public int Opacity
        {
            get { return OpacitySlide.Value; }
            set { OpacitySlide.Value = value; }
        }

        private void ThicknessSlide_ValueChanged(object sender, EventArgs e)
        {
            ThicknessTb.Text = ThicknessSlide.Value.ToString();
        }

        private void OpacitySlide_ValueChanged(object sender, EventArgs e)
        {
            OpacityTb.Text = OpacitySlide.Value.ToString();
        }

     
        public int getThickness()
        {
            if (ThicknessTb.Text != "")
                return Int32.Parse(ThicknessTb.Text);
            else
                return 0;
        }

        public int getOpacityText()
        {
            if (OpacityTb.Text != "")
                return Int32.Parse(OpacityTb.Text);
            else
                return 0;
        }

        private void ThicknessTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            if (keycode >= 48 && keycode <= 57 || keycode == 8)
            {
            }
            else e.Handled = true;

            if(keycode == 13)
            {
                ThicknessSlide.Value = getThickness();
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void OpacityTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            if (keycode >= 48 && keycode <= 57 || keycode == 8)
            {
            }
            else e.Handled = true;

            if(keycode == 13)
            {
                OpacitySlide.Value = getOpacityText();
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
            
        }
    }
}
