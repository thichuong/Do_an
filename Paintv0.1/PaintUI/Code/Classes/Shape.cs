using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintUI
{
    class Shape
    {
        static public PointF[] FormHexagon(Point old, Point cur, Size size)
        {
            PointF[] hexagon = { new PointF(old.X, (float)(old.Y + size.Height / 4)), new PointF(old.X, (float)(old.Y + size.Height / 4 * 3)),
                            new PointF((float)(old.X + size.Width / 2), (float)(old.Y + size.Height)), new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height / 4 * 3)),
                            new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height / 4)), new PointF((float)(old.X + size.Width / 2), old.Y) };
            return hexagon;
        }

        static public PointF[] FormIsoTriangle(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X, old.Y), new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height)),
                            new PointF(old.X, (float)(old.Y + size.Height)) };
            return vertices;
        }

        static public PointF[] FormArrow(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X, (float)(old.Y + size.Height / 4)), new PointF((float)(old.X + size.Width / 2), (float)(old.Y + size.Height / 4)),
                            new PointF((float)(old.X + size.Width/2), old.Y), new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height/2)),
                            new PointF((float)(old.X + size.Width/2), (float)(old.Y + size.Height)), new PointF((float)(old.X + size.Width/2), (float)(old.Y + size.Height/4*3)),
                            new PointF(old.X, (float)(old.Y + size.Height/4*3))};
            return vertices;
        }

        static public PointF[] FormStar(Point old, Point cur, Size size)
        {
            PointF[] vertices = {new PointF(old.X + (float)size.Width/2, old.Y), new PointF(old.X + (float)size.Width/5*2, old.Y + (float)size.Height/5*2),
                                new PointF(old.X, old.Y + (float)size.Height/5*2), new PointF(old.X + (float)size.Width/10*3, old.Y + (float)size.Height/5*3),
                                new PointF(old.X + (float)size.Width/5, old.Y + (float)size.Height),  new PointF(old.X + (float)size.Width/2, old.Y + (float)size.Height/4*3),
                                new PointF(old.X + (float)size.Width/5*4, old.Y + (float)size.Height), new PointF(old.X + (float)size.Width/10*7, old.Y + (float)size.Height/5*3),
                                new PointF(old.X + (float)size.Width, old.Y + (float)size.Height/5*2), new PointF(old.X + (float)size.Width/5*3, old.Y + (float)size.Height/5*2) };
            return vertices;
        }

        static public PointF[] FormTriangle(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X, (float)(old.Y + size.Height)), new PointF((float)(old.X + size.Width / 2), old.Y),
                        new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height))};
            return vertices;
        }

        static public PointF[] FormLightning(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X + (float)(size.Width / 4), old.Y), new PointF(old.X, (float)(old.Y + size.Height / 2)),
                        new PointF((float)(old.X + size.Width / 5 * 2), (float)(old.Y + size.Height / 2)), new PointF((float)(old.X+size.Width / 5), (float)(old.Y + size.Height)),
                        new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height / 4)), new PointF((float)(old.X + size.Width / 5 * 3), (float)(old.Y + size.Height / 4)),
                        new PointF((float)(old.X + size.Width / 4 * 3), old.Y), new PointF((float)(old.X + size.Width / 4 * 3), old.Y),
                        new PointF((float)(old.X + size.Width / 4), old.Y)};
            return vertices;
        }

        static public GraphicsPath FormRHeart(Point old, Point cur, Size size)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(old.X + size.Width / 2, old.Y + size.Height / 3,
                            old.X + size.Width * 0.9f, old.Y,
                            old.X + size.Width, old.Y + size.Height * 0.75f,
                            old.X + size.Width / 2, old.Y + size.Height);
            return path;
        }

        static public GraphicsPath FormLHeart(Point old, Point cur, Size size)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(old.X + size.Width / 2, old.Y + size.Height / 3,
                            old.X + size.Width * 0.1f, old.Y,
                            old.X, old.Y + size.Height * 0.75f,
                            old.X + size.Width / 2, old.Y + size.Height);
            return path;
        }

        static public GraphicsPath FormWHeart(Point old, Point cur, Size size)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(old.X + size.Width / 2, old.Y + size.Height / 3,
                            old.X + size.Width * 0.9f, old.Y,
                            old.X + size.Width, old.Y + size.Height * 0.75f,
                            old.X + size.Width / 2, old.Y + size.Height);
            path.AddBezier(old.X + size.Width / 2, old.Y + size.Height / 3,
                            old.X + size.Width * 0.1f, old.Y,
                            old.X, old.Y + size.Height * 0.75f,
                            old.X + size.Width / 2, old.Y + size.Height);
            return path;
        }
    }
}
