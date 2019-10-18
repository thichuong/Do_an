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
        Pen pen;
        Bitmap bm;
        Graphics gra;
        Point old, cur;
        bool isDown;
        int wid, hei;

        public Form1()
        {
            InitializeComponent();
            HideAllPanel();
            brushesPanel.Show();
            pen = new Pen(Color.Black, 10);
            bm = new Bitmap(SketchBox.Width, SketchBox.Height, SketchBox.CreateGraphics());
            gra = Graphics.FromImage(bm);
            isDown = false;

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
            wid = hei = 0;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            menuPanel1.BringToFront();
        }

        private void SketchBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            old = new Point(e.Location.X, e.Location.Y);
        }

        private void SketchBox_Paint(object sender, PaintEventArgs e)
        {
            if(isDown)
            {
                gra.DrawLine(pen, old, cur);
                old = cur;
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
            }
        }

        //---------------

    }
}
