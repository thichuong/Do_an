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
    public partial class CalligraphyProp : BrushesPropeties
    {
        public CalligraphyProp()
        {
            InitializeComponent();

            Controls.Remove(OpacityLb);
            Controls.Remove(OpacitySlide);
            Controls.Remove(OpacityTb);
            Controls.Remove(label2);
            
        }
    }
}
