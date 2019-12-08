using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI
{
    class Sprayer
    {
        private Random ran = new Random();
        public bool spraying;
        private Thread thrd;
        private Point location;

        private static object locker = new object();

        public void StartSpraying(Graphics gra, int thickness, Point cur, Color color)
        {
            location = cur;
            spraying = true;
            thrd = new Thread(() => Spray(gra, thickness, color));
            thrd.Start();
        }

        public void Spray(Graphics gra, int thickness, Color color)
        {
            while (spraying)
            {
                int radius = thickness;
                for (int i = 0; i < thickness*2; ++i)
                {
                    double theta = ran.NextDouble() * (Math.PI * 2);
                    double r = ran.NextDouble() * radius;

                    // Transform the polar coordinate to cartesian (x,y)
                    // and translate the center to the current mouse position
                    double x = location.X + Math.Cos(theta) * r;
                    double y = location.Y + Math.Sin(theta) * r;

                    gra.CompositingMode = CompositingMode.SourceOver;
                    gra.SmoothingMode = SmoothingMode.AntiAlias;
                    gra.CompositingQuality = CompositingQuality.GammaCorrected;
                    gra.DrawEllipse(new Pen(color), new Rectangle((int)x - 1, (int)y - 1, 1, 1));
                }
                Thread.Sleep(50);
            }
        }

        public void StopSpraying()
        {
            spraying = false;
        }

        public void getLocation(Point cur)
        {
            location = cur;
        }
    }
}
