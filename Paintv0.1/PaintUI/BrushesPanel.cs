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
    public partial class BrushesPanel : UserControl
    {
        public event EventHandler ThicknessChange;
        public event EventHandler OpacityChange;

        public BrushesPanel()
        {
            InitializeComponent();
            thicknessSlide.Value = 10;
            opacitySlide.Value = 255;
        }

        private void thicknessSlide_ValueChanged(object sender, EventArgs e)
        {
            if (this.ThicknessChange != null)
                this.ThicknessChange(this, e);
        }

        
        private void opacitySlide_ValueChanged(object sender, EventArgs e)
        {
            if (this.OpacityChange != null)
                this.OpacityChange(this, e);
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
