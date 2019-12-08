using PaintUI.Code.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintUI.Code.Brushes
{
    abstract class Brush
    {
        protected Pen pen;

        virtual public void MouseDown(ref Graphics gra, Point cur, ref List<Point> _pts)
        {
            pen.DashStyle = DashStyle.Solid;
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            _pts = new List<Point>();
            _pts.Add(cur);
        }

        virtual public void MouseMove(Graphics gra, Point old, Point cur, Color colors)
        {

        }

        virtual public void MouseUp()
        {

        }

        virtual public void Paint(Graphics gra, Point cur, GraphicsPath gPath, List<Point> _pts)
        {
            _pts.Add(cur);
            gPath.AddLines(_pts.ToArray());
            pen.LineJoin = LineJoin.Round;
            gra.DrawPath(pen, gPath);
        }
    }
}
