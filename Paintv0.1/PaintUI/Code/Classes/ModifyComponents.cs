using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintUI.Code.Classes
{
    class ModifyComponents
    {
        static public void Graphics(Graphics gra)
        {
            gra.CompositingMode = CompositingMode.SourceOver;
            gra.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}
