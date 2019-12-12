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
            if (Name == "PelProp")
                ThicknessSlide.MaximumValue = 5;
            else ThicknessSlide.MaximumValue = 30;
            ThicknessSlide.Value = 10;
            OpacitySlide.Value = 255;
        }
        
        public int Thickness
        {
            get { return Name=="PelProp"?ThicknessSlide.Value/10 + 1:ThicknessSlide.Value+15; }
            set { ThicknessSlide.Value = value; }
        }

        public int Opacity
        {
            get { return OpacitySlide.Value; }
            set { OpacitySlide.Value = value; }
        }
    }
}
