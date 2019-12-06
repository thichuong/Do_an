using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintUI.Code.Brushes
{
    class CalligraphyPen : Brush
    {
        static private double standarSize, calliSize;
        static int distance;

        public CalligraphyPen(Color c, int Thickness)
        {
            this.pen = new Pen(c, Thickness);
            calliSize = standarSize = Thickness;
            distance = 0;
        }

        public override void MouseDown(Graphics gra, Point cur, ref List<Point> _pts)
        {
            calliSize = standarSize;
        }

        public override void MouseMove(Graphics gra, Point old, Point cur, Color color)
        {
            distance = Convert.ToInt32((cur.X - old.X) * (cur.X - old.X) + (cur.Y - old.Y) * (cur.Y - old.Y)) / 10;

            if (distance > 0)
            {
                if (distance < 15 && calliSize <= standarSize)
                    calliSize += standarSize / 20;
                else if (distance >= 5 && calliSize > standarSize / 10)
                    calliSize -= standarSize / 20;
            }
            pen = new Pen(color, (float)calliSize);
            pen.DashStyle = DashStyle.Solid;
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            gra.CompositingMode = CompositingMode.SourceOver;
            gra.DrawLine(pen, old, cur);
        }

        public override void MouseUp()
        {
            calliSize = standarSize;
        }
    }
}
