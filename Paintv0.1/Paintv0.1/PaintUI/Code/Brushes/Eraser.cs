using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintUI.Code.Brushes
{
    class Eraser : Brush
    {
        public Eraser(int Thickness)
        {
            this.pen = new Pen(Color.Transparent, Thickness);
        }
        
    }
}
