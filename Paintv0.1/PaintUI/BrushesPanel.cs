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
       public int curSize;
        public BrushesPanel()
        {
            InitializeComponent();
            curSize=Brushes_SizeSlider.Value = 4;
            Brushes_SizeSlider.MaximumValue = 20;
        }

        private void Brushes_SizeSlider_ValueChanged(object sender, EventArgs e)
        {
            curSize = Brushes_SizeSlider.Value;
        }
    }
}
