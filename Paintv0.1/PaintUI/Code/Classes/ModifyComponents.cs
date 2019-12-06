using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintUI.Code.Class
{
    class ModifyComponents
    {
        static public void Graphics(Graphics gra)
        {
            gra.CompositingMode = CompositingMode.SourceCopy;
            gra.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}
