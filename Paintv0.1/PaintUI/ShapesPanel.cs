using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Bunifu.Framework.UI;

namespace PaintUI
{
    public partial class ShapesPanel : UserControl
    {
        Pen pen;
        Brush brush;

        ShapeSelections selShape;

        bool fill;
        bool outline;


        public ShapesPanel()
        {
            InitializeComponent();
            pen = new Pen(colorPanel.getColor1(), 5);
            brush = new SolidBrush(colorPanel.getColor2());

            fill = false;
            outline = true;

            Shapes_FillCheckBox.Checked = false;
            Shapes_OutlineCheckBox.Checked = true;
            
            selShape = new ShapeSelections();
            selShape.Location = new Point(0, curShapeBtn.Location.Y+curShapeBtn.Size.Height + 10);
            selShape.Size = new Size(Width+20, 0);
            Controls.Add(selShape);
            selShape.Show();
            selShape.BringToFront();

            selShape.ShapeSelected += SelShape_ShapeSelected;
        }
        
        private void SelShape_ShapeSelected(object sender, EventArgs e)
        {
            curShapeBtn.BackgroundImage = selShape.getImage();
            
            Slider slider = new Slider(selShape);
        }

        private void curShapeBtn_Leave(object sender, EventArgs e)
        {
            curShapeBtn.BackgroundImage = selShape.getImage();

            Slider slider = new Slider(selShape);
        }

        //Button Click
        private void curShapeBtn_Click(object sender, EventArgs e)
        {
            Slider slider = new Slider(selShape);
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
        public void FillShapes(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size, Brush fillColor)
        {
            switch (selShape.getShape())
            {
                case 0: //rec
                    g.FillRectangle(fillColor, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case 1: //elp
                    g.FillEllipse(fillColor, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case 2: //line
                    break;
                case 3: //arr
                    g.FillPolygon(fillColor, arrowVertices(old, cur, size));
                    break;
                case 4: //star
                    g.FillPolygon(fillColor, starVertices(old, cur, size));
                    break;
                case 5: //tri
                    g.FillPolygon(fillColor, triangleVertices(old, cur, size));
                    break;
                case 6: //lgt
                    g.FillPolygon(fillColor, lightningVertices(old, cur, size));
                    break;
                case 7: //iso
                    g.FillPolygon(fillColor, isoTriangleVertices(old, cur, size));
                    break; 
                case 8: //iso
                    g.FillPolygon(fillColor, hexagonVertices(old, cur, size));
                    break;
                default:
                    break;
            }
        }

        public void DrawOutline(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size)
        {
            switch (selShape.getShape())
            {
                case 0: // rec
                    g.DrawRectangle(pen, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case 1: //elp
                    g.DrawEllipse(pen, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case 2: //line
                    g.DrawLine(pen, old, cur);
                    break;
                case 3: //arr
                    g.DrawPolygon(pen, arrowVertices(old, cur, size));
                    break;
                case 4: //star
                    g.DrawPolygon(pen, starVertices(old, cur, size));
                    break;
                case 5: //tri
                    g.DrawPolygon(pen, triangleVertices(old, cur, size));
                    break;
                case 6: //lgt
                    g.DrawPolygon(pen, lightningVertices(old, cur, size));
                    break;
                case 7: //iso
                    g.DrawPolygon(pen, isoTriangleVertices(old, cur, size));
                    break; 
                case 8: //iso
                    g.DrawPolygon(pen, hexagonVertices(old, cur, size));
                    break;
                default:
                    break;
            }
        }

        public void DrawShapes(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size)
        {
            if(fill)
            {
                brush.Dispose();
                brush = new SolidBrush(colorPanel.getColor2());

                FillShapes(p, bm, g, old, cur, size, brush);
            }
            if(outline)
            {
                pen.Dispose();
                pen = new Pen(colorPanel.getColor1(), thicknessSlide.Value);
                
                DrawOutline(p, bm, g, old, cur, size);
            }
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

        



        //pen.DashStyle = DashStyle.Solid;
        //pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
    }
}
