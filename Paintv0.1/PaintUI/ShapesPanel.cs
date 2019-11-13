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
    public partial class ShapesPanel : UserControl
    {
        enum Shapes { RECTANGLE, ELLIPSE, LINE, HEXAGON, STAR, ISO_TRIANGLE, TRIANGLE, ARROW, LIGHTNING};
        Shapes curShape;
        bool fill = false;
        bool outline = true;
        public ShapesPanel()
        {
            InitializeComponent();
            curShape = Shapes.RECTANGLE;
            Shapes_FillCheckBox.Checked = false;
            Shapes_OutlineCheckBox.Checked = true;
        }


        //Button Click
        private void rectangleButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.RECTANGLE;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.ELLIPSE;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.LINE;
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.ARROW;
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.STAR;
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.TRIANGLE;
        }

        private void lightningButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.LIGHTNING;
        }

        private void iso_triangleButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.ISO_TRIANGLE;
        }

        private void hexagonButton_Click(object sender, EventArgs e)
        {
            curShape = Shapes.HEXAGON;
        }

        

        //Tao cac dinh cua shape
        private PointF[] hexagonVertices(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X, (float)(old.Y + size.Height / 4)), new PointF(old.X, (float)(old.Y + size.Height / 4 * 3)),
                            new PointF((float)(old.X + size.Width / 2), (float)(old.Y + size.Height)), new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height / 4 * 3)),
                            new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height / 4)), new PointF((float)(old.X + size.Width / 2), old.Y) };
            return vertices;
        }

        private PointF[] isoTriangleVertices(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X, old.Y), new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height)),
                            new PointF(old.X, (float)(old.Y + size.Height)) };
            return vertices;
        }

        private PointF[] arrowVertices(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X, (float)(old.Y + size.Height / 4)), new PointF((float)(old.X + size.Width / 2), (float)(old.Y + size.Height / 4)),
                            new PointF((float)(old.X + size.Width/2), old.Y), new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height/2)),
                            new PointF((float)(old.X + size.Width/2), (float)(old.Y + size.Height)), new PointF((float)(old.X + size.Width/2), (float)(old.Y + size.Height/4*3)),
                            new PointF(old.X, (float)(old.Y + size.Height/4*3))};
            return vertices;
        }

        private PointF[] starVertices(Point old, Point cur, Size size)
        {
            PointF[] vertices = {new PointF(old.X + (float)size.Width/2, old.Y), new PointF(old.X + (float)size.Width/5*2, old.Y + (float)size.Height/5*2),
                                new PointF(old.X, old.Y + (float)size.Height/5*2), new PointF(old.X + (float)size.Width/10*3, old.Y + (float)size.Height/5*3),
                                new PointF(old.X + (float)size.Width/5, old.Y + (float)size.Height),  new PointF(old.X + (float)size.Width/2, old.Y + (float)size.Height/4*3),
                                new PointF(old.X + (float)size.Width/5*4, old.Y + (float)size.Height), new PointF(old.X + (float)size.Width/10*7, old.Y + (float)size.Height/5*3),
                                new PointF(old.X + (float)size.Width, old.Y + (float)size.Height/5*2), new PointF(old.X + (float)size.Width/5*3, old.Y + (float)size.Height/5*2) };
            return vertices;
        }

        private PointF[] triangleVertices(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X, (float)(old.Y + size.Height)), new PointF((float)(old.X + size.Width / 2), old.Y),
                        new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height))};
            return vertices;
        }

        private PointF[] lightningVertices(Point old, Point cur, Size size)
        {
            PointF[] vertices = { new PointF(old.X + (float)(size.Width / 4), old.Y), new PointF(old.X, (float)(old.Y + size.Height / 2)),
                        new PointF((float)(old.X + size.Width / 5 * 2), (float)(old.Y + size.Height / 2)), new PointF((float)(old.X+size.Width / 5), (float)(old.Y + size.Height)),
                        new PointF((float)(old.X + size.Width), (float)(old.Y + size.Height / 4)), new PointF((float)(old.X + size.Width / 5 * 3), (float)(old.Y + size.Height / 4)),
                        new PointF((float)(old.X + size.Width / 4 * 3), old.Y), new PointF((float)(old.X + size.Width / 4 * 3), old.Y),
                        new PointF((float)(old.X + size.Width / 4), old.Y)};
            return vertices;
        }


        //draw outline and fill color
        public void FillShapes(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size, Pen pen, Brush fillColor)
        {
            switch (curShape)
            {
                case Shapes.RECTANGLE:
                    g.FillRectangle(fillColor, Math.Min(old.X, cur.X), Math.Min(old.Y, cur.Y), Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case Shapes.ELLIPSE:
                    g.FillEllipse(fillColor, Math.Min(old.X, cur.X), Math.Min(old.Y, cur.Y), Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case Shapes.HEXAGON:
                    g.FillPolygon(fillColor, hexagonVertices(old, cur, size));
                    break;
                case Shapes.STAR:
                    g.FillPolygon(fillColor, starVertices(old, cur, size));
                    break;
                case Shapes.ISO_TRIANGLE:
                    g.FillPolygon(fillColor, isoTriangleVertices(old, cur, size));
                    break;
                case Shapes.ARROW:
                    g.FillPolygon(fillColor, arrowVertices(old, cur, size));
                    break;
                case Shapes.TRIANGLE:
                    g.FillPolygon(fillColor, triangleVertices(old, cur, size));
                    break;
                case Shapes.LIGHTNING:
                    g.FillPolygon(fillColor, lightningVertices(old, cur, size));
                    break;
                default:
                    break;
            }
        }

        public void DrawOutline(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size, Pen pen)
        {
            switch (curShape)
            {
                case Shapes.RECTANGLE:
                    g.DrawRectangle(pen, Math.Min(old.X, cur.X), Math.Min(old.Y, cur.Y), Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case Shapes.ELLIPSE:
                    g.DrawEllipse(pen, Math.Min(old.X, cur.X), Math.Min(old.Y, cur.Y), Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case Shapes.LINE:
                    g.DrawLine(pen, old, cur);
                    break;
                case Shapes.HEXAGON:
                    {
                        Point[] vertices1 = { new Point(old.X, old.Y + size.Height / 4), new Point(old.X, old.Y + size.Height / 4 * 3),
                            new Point(old.X + size.Width / 2, old.Y + size.Height), new Point(old.X + size.Width, old.Y + size.Height / 4 * 3),
                            new Point(old.X + size.Width, old.Y + size.Height / 4), new Point(old.X + size.Width / 2, old.Y) };
                        g.DrawPolygon(pen, vertices1);
                        break;
                    }
                case Shapes.STAR:
                    g.DrawPolygon(pen, starVertices(old, cur, size));
                    break;
                case Shapes.ISO_TRIANGLE:
                    {
                        Point[] vertices2 = { new Point(old.X, old.Y), new Point(old.X + size.Width, old.Y + size.Height),
                            new Point(old.X, old.Y + size.Height) };
                        g.DrawPolygon(pen, vertices2);
                        break;
                    }
                case Shapes.ARROW:
                    {
                        Point[] vertices = { new Point(old.X, old.Y + size.Height / 4), new Point(old.X + size.Width / 2, old.Y + size.Height / 4),
                            new Point(old.X + size.Width/2, old.Y), new Point(old.X + size.Width, old.Y + size.Height/2),
                            new Point(old.X + size.Width/2, old.Y + size.Height), new Point(old.X + size.Width/2, old.Y + size.Height/4*3),
                            new Point(old.X, old.Y + size.Height/4*3)};
                        g.DrawPolygon(pen, vertices);    
                        break;
                    }
                case Shapes.TRIANGLE:
                    {
                        Point[] vertices = { new Point(old.X, old.Y + size.Height), new Point(old.X + size.Width / 2, old.Y),
                            new Point(old.X + size.Width, old.Y + size.Height)};
                        g.DrawPolygon(pen, vertices);
                        break;
                    }
                case Shapes.LIGHTNING:
                    {
                        Point[] vertices = { new Point(old.X + size.Width / 4, old.Y), new Point(old.X, old.Y + size.Height / 2),
                            new Point(old.X + size.Width / 5 * 2, old.Y + size.Height / 2), new Point(old.X+size.Width / 5, old.Y + size.Height),
                            new Point(old.X + size.Width, old.Y + size.Height / 4), new Point(old.X + size.Width / 5 * 3, old.Y + size.Height / 4),
                            new Point(old.X + size.Width / 4 * 3, old.Y), new Point(old.X + size.Width / 4 * 3, old.Y),
                            new Point(old.X + size.Width / 4, old.Y)};
                        g.DrawPolygon(pen, vertices);
                        break;
                    }
                default:
                    break;
            }
        }

        public void DrawShapes(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size, Pen pen,Brush fillColor)
        {
            if(fill)
            {
                FillShapes(p, bm, g, old, cur, size, pen, fillColor);
            }
            if(outline)
                DrawOutline(p, bm, g, old, cur, size, pen);
        }



        private void Shapes_FillCheckBox_OnChange(object sender, EventArgs e)
        {
            if(fill)
                fill = false;
            else
                fill = true;
        }

        private void Shapes_OutlineCheckBox_OnChange(object sender, EventArgs e)
        {
            if (outline)
                outline = false;
            else
                outline = true;
        }
        
    }
}
