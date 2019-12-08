using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintUI
{
    class Sprayer
    {
        static public void Spray(Graphics gra, int thickness, Point cur, Color color)
        {
            Random ran = new Random();
            int radius = thickness;
            for (int i = 0; i < 5; ++i)
            {
                // Select random Polar coordinate
                // where theta is a random angle between 0..2*PI
                // and r is a random value between 0..radius
                double theta = ran.NextDouble() * (Math.PI * 2);
                double r = ran.NextDouble() * radius;

                // Transform the polar coordinate to cartesian (x,y)
                // and translate the center to the current mouse position
                double x = cur.X + Math.Cos(theta) * r;
                double y = cur.Y + Math.Sin(theta) * r;

                gra.DrawEllipse(new Pen(color), new Rectangle((int)x - 1, (int)y - 1, 2, 2));
            }
        }

        
    }
}
