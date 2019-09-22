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



namespace DrawInPaint
{

    public enum Shape { PEN, ERASER, RECTANGLE, ELLIPSE }

    public partial class Form1 : Form
    {
        //Khai bao bien
        //Pen, doan thang
        Point old, current;

        Color curColor = Color.Black;
        Pen pen;
        Graphics gra;
        Bitmap bm;
        Shape curShape;
        int Seclet=1;

        int curSize = 1;
        bool isDown = false;
   
        int wid, hei;

        public Form1()
        {
            InitializeComponent();
            InitComboBox();
            bm = new Bitmap(this.Width, this.Height);
            gra = Graphics.FromImage(bm);
            pen = new Pen(Color.Black, curSize);
            curShape = Shape.PEN;

            //Dieu chinh net ve cho but
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            //Giam hien tuong rung khi ve
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
           

            //Tang do muot cho net ve
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        }

        
        //ColorButton

        


        //ComboBox

        private void InitComboBox()
        {
            for(int i=2; i<=10; i+=2)
            {
                ComboBox1.Items.Add(i);
            }
            ComboBox1.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = new Pen(curColor, Convert.ToInt32(ComboBox1.Text));
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void RightColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                RightColor.BackColor = cld.Color;
                curColor = cld.Color;
                pen.Color = cld.Color;
            }
        }
        //Xu li cac su kien chuot de ve

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            switch(Seclet)
            {
                case 2:
                    gra.DrawRectangle(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                    this.BackgroundImage = (Bitmap)bm.Clone();
                    break;
                case 3:
                    gra.DrawEllipse(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                    this.BackgroundImage = (Bitmap)bm.Clone();
                    break;
                default:
                    break;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            old = new Point(e.Location.X, e.Location.Y);
            if (Seclet==4 )
            {
                 Color targetColor = bm.GetPixel(e.X,e.Y);
                 FloodFill(bm, e.Location,bm.GetPixel(e.X,e.Y) , pen.Color);
                 this.BackgroundImage = (Bitmap)bm.Clone();

            }


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            wid = current.X - old.X;
            hei = current.Y - old.Y;
            if (isDown)
            {
                current = new Point(e.Location.X, e.Location.Y);
                this.Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (isDown)
            {
                switch(Seclet)
                {
                    case 1:

                        gra.DrawLine(pen, old, current);
                        old = current;
                        this.BackgroundImage = (Bitmap)bm.Clone();
                        break;
                    case 2:
                        e.Graphics.DrawRectangle(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                        break;
                    case 3:
                        e.Graphics.DrawEllipse(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                        break;
                   

                    default:
                        break;
                }

            }

        }

        //Cac Shape de ve

        private void PenButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.PEN;
            Seclet = 1;
            
        }

        private void BucketButton_Click(object sender, EventArgs e)
        {
            Seclet = 4;
        }
        
        private void FloodFill(Bitmap bmp, Point pt,Color ponitColor,  Color replaceColor)
        {
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
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
 
                        Point next = new Point(cur.X , cur.Y -1);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == From)
                            {
                                check.Push(next);
                                bits[next.X + next.Y * data.Stride / 4] = To;
                            }
                        }
                        next = new Point(cur.X, cur.Y + 1);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == From)
                            {
                                check.Push(next);
                                bits[next.X + next.Y * data.Stride / 4] = To;
                            }
                        }
                        next = new Point(cur.X - 1, cur.Y );
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == From)
                            {
                                check.Push(next);
                                bits[next.X + next.Y * data.Stride / 4] = To;
                            }
                        }
                        next = new Point(cur.X + 1, cur.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == From)
                            {
                                check.Push(next);
                                bits[next.X + next.Y * data.Stride / 4] = To;
                            }
                        }
                    
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bmp.UnlockBits(data);
            this.Refresh();
        }
       
        private void RecButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.RECTANGLE;
            Seclet = 2;

        }

        private void ElipseButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.ELLIPSE;
            Seclet = 3;
        }

        
    }
}
