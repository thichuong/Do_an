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
            ThicknessSlide.MaximumValue = 70;
            ThicknessSlide.Value = 20;
            OpacitySlide.MaximumValue = 100;
            OpacitySlide.Value = 50;
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

        
        
        public int getThickness()
        {
            if (ThicknessTb.Text != "")
                return Int32.Parse(ThicknessTb.Text);
            else
                return 0;
        }

        public int getCanvasTextHeight()
        {
            if (OpacityTb.Text != "")
                return Int32.Parse(OpacityTb.Text);
            else
                return 0;
        }

        private void BrushesPropeties_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            if (keycode >= 48 && keycode <= 57 || keycode == 8)
            {
            }
            else e.Handled = true;
            if (keycode == 13)
            {
                ThicknessSlide.Value = Convert.ToInt32(ThicknessTb.Text);
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
            if (keycode == 13)
            {
                OpacitySlide.Value = Convert.ToInt32(OpacityTb.Text);
            }
        }
    }
}
