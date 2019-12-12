using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI.Code.Properties
{
    public partial class FillProp : BrushesPropeties
    {
        public FillProp()
        {
            InitializeComponent();

            OpacityLb.Location = ThicknessLb.Location;
            OpacitySlide.Location = ThicknessSlide.Location;

            Controls.Remove(ThicknessLb);
            Controls.Remove(ThicknessSlide);
            
        }
    }
}
