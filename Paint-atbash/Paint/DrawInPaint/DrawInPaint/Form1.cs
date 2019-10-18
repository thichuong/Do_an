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

    public enum Shape { BRUSH, ERASER, RECTANGLE, ELLIPSE, LINE, FILLBUCKET }

    public partial class Form1 : Form
    {
        //Declare variables

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
        



        //Initiate form
        public Form1()
        {
            InitializeComponent();
            InitComboBox();

            bm = new Bitmap(this.Width, this.Height);
            gra = Graphics.FromImage(bm);

            fColor = Color.Black;
            bColor = Color.White;

            pen = new Pen(fColor, curSize);
            eraser = new SolidBrush(bColor);


            curShape = Shape.BRUSH;
            ButtonPanel.Width = this.Width;
            ButtonPanel.Cursor = Cursors.Default;


            

            isDown = false;
            curSize = 10;


            //Default cursor
            this.Cursor = Cursors.Cross;



            //Handle with Buttons' image
            //brush
            Image tempImg1 = Image.FromFile("Images\\brush.png");
            BrushButton.Image = Resize(tempImg1, BrushButton.Width*0.8, BrushButton.Height*0.8);

            //fill
            Image tempImg2 = Image.FromFile("Images\\fillBucket.png");
            FillButton.Image = Resize(tempImg2, BrushButton.Width*0.8, BrushButton.Height*0.8);

            //eraser
            Image tempImg3 = Image.FromFile("Images\\eraser.png");
            EraserButton.Image = Resize(tempImg3, BrushButton.Width*0.8, BrushButton.Height*0.8);




            //Modify stroke
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            

            //Smoothing
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }


        //Handle drawing panel's size
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            ButtonPanel.Width = this.Width;

            Bitmap temp = bm;
            bm = new Bitmap(this.Width, this.Height);
            gra = Graphics.FromImage(bm);
            gra.DrawImage(temp, 0, 0, temp.Width, temp.Height);
            this.BackgroundImage = (Bitmap)bm.Clone();
        }


        //ColorButton

        private void ForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                foreColor.BackColor = cld.Color;
                fColor = cld.Color;
                pen = new Pen(fColor, curSize);
                pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            }
        }

        private void BackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                backColor.BackColor = cld.Color;
                bColor = cld.Color;
                eraser = new SolidBrush(bColor);
            }
        }




        //ComboBox

        private void InitComboBox()
        {
            for(int i=2; i<=10; i+=2)
            {
                ComboBox1.Items.Add(i);
            }
            ComboBox1.SelectedIndex = 4;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            curSize = Convert.ToInt32(ComboBox1.Text);
            pen = new Pen(fColor, curSize);
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            eraser = new SolidBrush(bColor);
        }

        

        //Mouse events

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            switch(curShape)
            {
                case Shape.RECTANGLE:
                    gra.DrawRectangle(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                    this.BackgroundImage = (Bitmap)bm.Clone();
                    break;
                case Shape.ELLIPSE:
                    gra.DrawEllipse(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                    this.BackgroundImage = (Bitmap)bm.Clone();
                    break;
                case Shape.LINE:
                    gra.DrawLine(pen,old, current);
                    this.BackgroundImage = (Bitmap)bm.Clone();
                    break;
                default:
                    break;
            }
            wid = hei = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            old = new Point(e.Location.X, e.Location.Y);
            if (curShape == Shape.FILLBUCKET )
            {
                Color targetColor = bm.GetPixel(e.X,e.Y);

                Fill(bm, e.Location,bm.GetPixel(e.X,e.Y) , pen.Color);
                this.BackgroundImage = (Bitmap)bm.Clone();
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                current = new Point(e.Location.X, e.Location.Y);
                wid = current.X - old.X;
                hei = current.Y - old.Y;
                this.Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isDown)
            {
                switch(curShape)
                {
                    case Shape.BRUSH:
                        gra.DrawLine(pen, old, current);
                        old = current;
                        this.BackgroundImage = (Bitmap)bm.Clone();
                        break;
                    case Shape.RECTANGLE:
                        e.Graphics.DrawRectangle(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                        break;
                    case Shape.ELLIPSE:
                        e.Graphics.DrawEllipse(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                        break;
                    case Shape.LINE:
                        gra.DrawLine(pen, old, current);
                        this.BackgroundImage = (Bitmap)bm.Clone();
                        break;
                    case Shape.ERASER:
                        gra.FillRectangle(eraser, current.X-curSize, current.Y-curSize, curSize, curSize);
                        Pen temp = new Pen(bColor, curSize * 2);
                        temp.SetLineCap(System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.DashCap.Round);
                        gra.DrawLine(temp, old, current);
                        old = current;
                        this.BackgroundImage = (Bitmap)bm.Clone();
                        break;
                    default:
                        break;
                }
            }
        }


        //Shapes

        private void PenButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.BRUSH;
            this.Cursor = Cursors.Cross;
        }
        
        private void RecButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.RECTANGLE;
            this.Cursor = Cursors.Cross;
        }
        
        private void ElipseButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.ELLIPSE;
            this.Cursor = Cursors.Cross;
        }
        
        private void FillBucketButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.FILLBUCKET;
            Bitmap bmp = new Bitmap(new Bitmap("Images\\fillBucket.png"), 30, 30);
            this.Cursor = new Cursor(bmp.GetHicon());
        }
        
        private void EraserButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.ERASER;
            Bitmap bmp = new Bitmap(new Bitmap("Images\\eraserCursor.png"), curSize*2, curSize*2);
            this.Cursor = new Cursor(bmp.GetHicon());
        }

        //Fill color
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

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }

                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bmp.UnlockBits(data);
            this.Refresh();
        }



        //Elements of menu strip

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want you exit", "Paint", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bmp (*.bmp)|*.bmp|Jpg (*.jpg)|*.jpg|Jpeg (*.jpeg)|*.jpeg|Png (*.png)|*.png";

            if (sfd.ShowDialog()==DialogResult.OK)
            {
                bm.Save(sfd.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files(*.jpg,*.jpeg, *.png, *.bmp)|*jpg; *jpeg; **png; *bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                bm = new Bitmap(this.Width, this.Height);
                gra = Graphics.FromImage(bm);
                gra.DrawImage(img, new Rectangle(0, 0, bm.Width, bm.Height));
                this.Refresh();
                this.BackgroundImage = (Bitmap)bm.Clone();
                
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bm = new Bitmap(this.Width, this.Height);
            gra = Graphics.FromImage(bm);
            this.Refresh();
            this.BackgroundImage = (Bitmap)bm.Clone();
        }



        //Resize an image
        Image Resize(Image img, double w, double h)
        {
            Bitmap tempBm = new Bitmap((int)w, (int)h);
            Graphics tempGra = Graphics.FromImage(tempBm);
            tempGra.DrawImage(img, 0, 0, (int)w, (int)h);
            tempGra.Dispose();

            return tempBm;
        }
        

    }
}
