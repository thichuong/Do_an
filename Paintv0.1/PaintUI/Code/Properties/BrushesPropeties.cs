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
    }
}
