using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (curShape != Shape.PEN)
            {
                if (curShape == Shape.RECTANGLE)
                    gra.DrawRectangle(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                else if(curShape ==Shape.ELLIPSE)
                    gra.DrawEllipse(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                this.BackgroundImage = (Bitmap)bm.Clone();
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            old = new Point(e.Location.X, e.Location.Y);


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
                if (curShape == Shape.PEN)
                {
                    gra.DrawLine(pen, old, current);
                    old = current;
                    this.BackgroundImage = (Bitmap)bm.Clone();
                }
                else if (curShape == Shape.RECTANGLE)
                {
                    e.Graphics.DrawRectangle(pen, wid>0 ? old.X : current.X, hei>0 ? old.Y: current.Y , Math.Abs(wid), Math.Abs(hei));
                }
                else if(curShape == Shape.ELLIPSE)
                {
                    e.Graphics.DrawEllipse(pen, wid > 0 ? old.X : current.X, hei > 0 ? old.Y : current.Y, Math.Abs(wid), Math.Abs(hei));
                }
            }

        }

        //Cac Shape de ve

        private void PenButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.PEN;
            
        }

        private void RecButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.RECTANGLE;
        }

        private void ElipseButton_Click(object sender, EventArgs e)
        {
            curShape = Shape.ELLIPSE;
        }

        
    }
}
