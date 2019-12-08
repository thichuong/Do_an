using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintUI.Code.Brushes
{
    class Pencil : Brush
    {
        public Pencil(Color c, int Thickness)
        {
            this.pen = new Pen(c, Thickness);
        }
    }
}
