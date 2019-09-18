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
    public partial class Form1 : Form
    {
        //Khai bao bien
        Point old = new Point();
        Point current = new Point();
        Color currentColor = Color.Black;
        Pen pen;
        Graphics gra;
        Bitmap bm;
        enum Tool{PEN, BRUSH, ERASER, SPECIAL_SHAPE };

        int currentSize = 1;
        bool isDown = false;

        public Form1()
        {
            InitializeComponent();
            InitComboBox();
            bm = new Bitmap(this.Width, this.Height);
            gra = Graphics.FromImage(bm);
            pen = new Pen(Color.Black, currentSize);

            //Dieu chinh net ve cho but
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            //Giam hien tuong rung khi ve
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

        }

        

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if(cld.ShowDialog() == DialogResult.OK)
            {
                ColorButton.BackColor = cld.Color;
                currentColor = cld.Color;
                pen.Color = cld.Color;
            }
        }

        private void InitComboBox()
        {
            for(int i=2; i<=10; i+=2)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = new Pen(currentColor, Convert.ToInt32(comboBox1.Text));
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            Pen pen = new Pen(currentColor, currentSize);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            old = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                current = e.Location;
                gra.DrawLine(pen, old, current);
                this.BackgroundImage = (Bitmap)bm.Clone();
                old = current;
            }
        }
    }
}
