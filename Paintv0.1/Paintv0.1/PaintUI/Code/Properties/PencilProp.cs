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
    public partial class PencilProp : BrushesPropeties
    {
        public PencilProp()
        {
            InitializeComponent();
            ThicknessSlide.MaximumValue = 5;
            ThicknessSlide.Value = 2;
        }
    }
}
