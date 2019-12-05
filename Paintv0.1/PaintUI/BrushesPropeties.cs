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
        public BrushesPropeties(int type = 0)
        {
            InitializeComponent();

            Size = new Size(200, 200);

            if(type == 3)
            {
                opacityLb.Location = thicknessLb.Location;
                opacitySlide.Location = thicknessSlide.Location;
                Controls.Remove(thicknessLb);
                Controls.Remove(thicknessSlide);
            }

            if(type == 5)
            {
                Controls.Remove(opacityLb);
                Controls.Remove(opacitySlide);
            }
        }

        public int getThickness()
        {
            return thicknessSlide.Value;
        }

        public int getOpacity()
        {
            return opacitySlide.Value;
        }
    }
}
