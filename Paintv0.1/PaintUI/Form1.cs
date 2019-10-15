using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PaintUI
{
    public enum Shape { BRUSH, ERASER, RECTANGLE, ELLIPSE, LINE, FILLBUCKET }
    public partial class Form1 : Form
    {
        Point old, current;
        Color fColor;
        Color bColor;
        Pen pen;
        SolidBrush eraser;
        Graphics gra;
        Bitmap bm;
        Shape curShape;

        int curSize;
        bool isDown;
        int wid, hei;
        public Form1()
        {
            InitializeComponent();
            HideAllPanel();
            bm = new Bitmap(SketchBox.Width, SketchBox.Height, SketchBox.CreateGraphics());
            gra = Graphics.FromImage(bm);
            fColor = Color.Black;
            bColor = Color.White;
            curSize = 4;
            pen = new Pen(fColor, curSize);
            eraser = new SolidBrush(bColor);

            curShape = Shape.BRUSH;



            isDown = false;


            //Modify stroke
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);


            //Smoothing
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //Default cursor
            this.Cursor = Cursors.Cross;
            //Thiet lap ban dau
            gra.Clear(Color.White);
            bunifuSlider1_set();
        }
        //Giau Panels
        private void HideAllPanel()
        {
            ShapesPanel.Visible = false;
            TextPanel.Visible = false;
            CanvasPanel.Visible = false;
            BrushPanel.Visible = false;
            EffectsPanel.Visible = false;
            MenuPanel.Visible = false;
        }
        //Code cac chuc nang cho cac WindowState Butttons
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Hien thi cac Panels khi click
        private void TextButton_Click(object sender, EventArgs e)
        {
            if (!TextPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(TextPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
                bunifuTransition1.HideSync(TextPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
        }
        private void ShapesButton_Click(object sender, EventArgs e)
        {
            if (!ShapesPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(ShapesPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else

                bunifuTransition1.HideSync(ShapesPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
        }
        private void CanvasButton_Click(object sender, EventArgs e)
        {
            if (!CanvasPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(CanvasPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
                bunifuTransition1.HideSync(CanvasPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void BrushesButton_Click(object sender, EventArgs e)
        {
            if (!BrushPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(BrushPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else

                bunifuTransition1.HideSync(BrushPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            curShape = Shape.BRUSH;
            //tao gia tri slider chinh kich thuoc but ve
            bunifuSlider1_set();
        }
        private void EraserButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.ERASER;
        }
        private void EffectsButton_Click(object sender, EventArgs e)
        {
            if (!EffectsPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(EffectsPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
                bunifuTransition1.HideSync(EffectsPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (!MenuPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(MenuPanel, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
                bunifuTransition1.HideSync(MenuPanel, false, BunifuAnimatorNS.Animation.VertSlide);
        }

        private void SketchBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            old = new Point(e.Location.X, e.Location.Y);
            if (curShape == Shape.FILLBUCKET)
            {
                Fill(bm, e.Location, bm.GetPixel(e.X, e.Y), pen.Color);

                SketchBox.BackgroundImage = (Bitmap)bm.Clone();

            }
        }

        private void SketchBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                current = new Point(e.Location.X, e.Location.Y);
                wid = current.X - old.X;
                hei = current.Y - old.Y;

                SketchBox.Refresh();

            }
        }
        private void SketchBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            switch (curShape)
            {
                case Shape.RECTANGLE:
                    gra.DrawRectangle(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));

                    SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                    break;
                case Shape.ELLIPSE:
                    gra.DrawEllipse(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));

                    SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                    break;
                case Shape.LINE:
                    gra.DrawLine(pen, old, current);
                    SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                    break;
                default:
                    break;
            }

            wid = hei = 0;
        }
        private void SketchBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDown)
            {
                switch (curShape)
                {
                    case Shape.BRUSH:
                        gra.DrawLine(pen, old, current);
                        old = current;
                        SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                        break;
                    case Shape.RECTANGLE:
                        e.Graphics.DrawRectangle(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                        break;
                    case Shape.ELLIPSE:
                        e.Graphics.DrawEllipse(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                        break;
                    case Shape.LINE:
                        gra.DrawLine(pen, old, current);
                        SketchBox.BackgroundImage = (Bitmap)bm.Clone();

                        break;
                    case Shape.ERASER:
                        gra.FillRectangle(eraser, current.X - curSize, current.Y - curSize, curSize, curSize);
                        Pen temp = new Pen(bColor, curSize * 2);
                        temp.SetLineCap(System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.DashCap.Round);
                        gra.DrawLine(temp, old, current);
                        old = current;
                        SketchBox.BackgroundImage = (Bitmap)bm.Clone();

                        break;

                    default:
                        break;
                }

            }
        }

        private void Brushes_MoreColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                Brushes_ForeColorBox.BackColor = cld.Color;
                fColor = cld.Color;
                pen = new Pen(fColor, curSize);
                pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            }
        }

        private void RECTANGLE_Click(object sender, EventArgs e)
        {
            curShape = Shape.RECTANGLE;
        }

        private void ELLIPSE_Click(object sender, EventArgs e)
        {
            curShape = Shape.ELLIPSE;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.FILLBUCKET;
        }
        private void bunifuSlider1_set()
        {
            bunifuSlider1.MaximumValue = 20;
            
            bunifuSlider1.Value = curSize;
        }
        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            curSize = bunifuSlider1.Value;
            pen = new Pen(fColor, curSize);
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);


        }

      

        //---------------
        private void Fill(Bitmap bmp, Point pt, Color pointColor, Color replaceColor)
        {
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);
            int x = pt.X, y = pt.Y;
            Stack<Point> check = new Stack<Point>();
            int To = replaceColor.ToArgb();
            int From = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = To;
            if (From != To)
            {
                check.Push(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.Pop();

                    Point next = new Point(cur.X, cur.Y - 1);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X, cur.Y + 1);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X - 1, cur.Y);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X + 1, cur.Y);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }

                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bmp.UnlockBits(data);
            SketchBox.Refresh();

        }
    }
}

