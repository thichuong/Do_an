using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI
{
    public partial class Form1 : Form
    {
        //Khai bao bien
        enum Tools {BRUSH, SHAPE, FILLBUCKET};
        Tools curTool;
        Pen pen;
        Bitmap bm;
        Graphics gra;
        Point old, cur;
        bool isDown;
        int wid, hei;
        int penSize;

        public Form1()
        {
            InitializeComponent();
            HideAllPanel();
            brushesPanel.Show();
            penSize = 10;
            pen = new Pen(Color.Black, penSize);
            bm = new Bitmap(SketchBox.Width, SketchBox.Height, SketchBox.CreateGraphics());
            gra = Graphics.FromImage(bm);
            isDown = false;
            curTool = Tools.BRUSH;

            //Modify stroke
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);


            //Smoothing
            {
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gra.Clear(Color.White);
            }

        }
        //Giau Panels
        private void HideAllPanel()
        {
            shapesPanel.Visible = false;
            textPanel.Visible = false;
            canvasPanel.Visible = false;
            brushesPanel.Visible = false;
            effectsPanel.Visible = false;
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
            if (!textPanel.Visible)
            {
                HideAllPanel();
                BunifuTransition1.ShowSync(textPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            
        }
        private void ShapesButton_Click(object sender, EventArgs e)
        {
            if (!shapesPanel.Visible)
            {
                HideAllPanel();
                BunifuTransition1.ShowSync(shapesPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            curTool = Tools.SHAPE;
        }
        private void CanvasButton_Click(object sender, EventArgs e)
        {
            if (!canvasPanel.Visible)
            {
                HideAllPanel();
                BunifuTransition1.ShowSync(canvasPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
          
        }

        private void BrushesButton_Click(object sender, EventArgs e)
        {
            if (!brushesPanel.Visible)
            {
                HideAllPanel();
                BunifuTransition1.ShowSync(brushesPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            curTool = Tools.BRUSH;
        }
        private void EffectsButton_Click(object sender, EventArgs e)
        {
            if (!effectsPanel.Visible)
            {
                HideAllPanel();
                BunifuTransition1.ShowSync(effectsPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
                
        }

        //Cac su kien voi mouse
        private void SketchBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                cur = new Point(e.Location.X, e.Location.Y);
                wid = cur.X - old.X;
                hei = cur.Y - old.Y;
                SketchBox.Refresh();
            }
        }

        private void SketchBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            if(curTool == Tools.SHAPE)
            {
                shapesPanel.DrawShapes(SketchBox, bm, gra, old, cur, new Size(wid, hei), pen, true);
            }
            wid = hei = 0;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            menuPanel1.BringToFront();
        }


        private void SketchBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            pen = new Pen(colorPanel.curColor, penSize);
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            old = new Point(e.Location.X, e.Location.Y);
        }

        private void SketchBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDown)
            {
                switch (curTool)
                {
                    case Tools.BRUSH:
                        gra.DrawLine(pen, old, cur);
                        old = cur;
                        SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                        break;
                    case Tools.SHAPE:
                        shapesPanel.DrawShapes(SketchBox, bm, e.Graphics, old, cur, new Size(wid, hei), pen, false);
                        break;
                    
                        
                    /*case Shape.ERASER:
                        gra.FillRectangle(eraser, cur.X - curSize, cur.Y - curSize, curSize, curSize);
                        Pen temp = new Pen(bColor, curSize * 2);
                        temp.SetLineCap(System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.DashCap.Round);
                        gra.DrawLine(temp, old, cur);
                        old = cur;
                        pictureBox1.BackgroundImage = (Bitmap)bm.Clone();

                        break;*/

                    default:
                        break;
                }

            }
        }
        

        //---------------

    }
}
