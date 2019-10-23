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
        enum Shapes { RECTANGLE, ELLIPSE, LINE};
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

        public void DrawShapes(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size, Pen pen,Brush fillColor, bool assign)
        {
            if (fill)
            {
                switch (curShape)
                {
                    case Shapes.RECTANGLE:
                        g.FillRectangle(fillColor, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                        break;
                    case Shapes.ELLIPSE:
                        g.FillEllipse(fillColor, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                        break;
                    case Shapes.LINE:
                        g.DrawLine(pen, old, cur);
                        //p.BackgroundImage = (Bitmap)bm.Clone();

                        break;
                    default:
                        break;
                }
            }
            if(outline)
            {
                switch (curShape)
                {
                    case Shapes.RECTANGLE:
                        g.DrawRectangle(pen, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                        break;
                    case Shapes.ELLIPSE:
                        g.DrawEllipse(pen, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                        break;
                    case Shapes.LINE:
                        g.DrawLine(pen, old, cur);
                        //p.BackgroundImage = (Bitmap)bm.Clone();

                        break;
                    default:
                        break;
                }
            }
            
            if(assign) p.BackgroundImage = (Bitmap)bm.Clone();
        }

        private void Shapes_FillCheckBox_OnChange(object sender, EventArgs e)
        {
            if(fill)
            {
                fill = false;
            }
            else
            {
                fill = true;
            }
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
