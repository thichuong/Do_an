using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI
{
    public partial class Form1 : Form
    {
        enum Tools { BRUSH, SHAPE, FILLBUCKET, ERASER };

        Tools curTool;
        Pen pen;
        Bitmap bm;
        Graphics gra;
        Bitmap temp;
        Point old, cur;
        SolidBrush eraser, fillColor;
        
        bool isDown;
        bool isPanning,PanClicked,ZoomClicked;
        int wid, hei;
        int penSize;
        public Form1()
        {
            InitializeComponent();
            HideAllPanel();
            
            penSize = 10;
            pen = new Pen(Color.Black, penSize);
            pen.DashStyle = DashStyle.Dash;
            pen.Alignment = PenAlignment.Center;
            bm = new Bitmap(SketchBox.Width, SketchBox.Height, SketchBox.CreateGraphics());
            gra = Graphics.FromImage(bm);

            isDown = false;
            curTool = Tools.BRUSH;
            ZoomClicked = false;

            MenuPanel1.BringToFront();
            SketchBox.Cursor = Cursors.Cross;

            //Modify stroke
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.RoundAnchor, System.Drawing.Drawing2D.LineCap.RoundAnchor, System.Drawing.Drawing2D.DashCap.Round);


            //Smoothing
            {
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

                gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gra.Clear(Color.White);
                this.SketchBox.MouseWheel += SketchBox_MouseWheel;
                this.MouseWheel += Form1_MouseWheel;
            }
            
        }
        
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
           
        }

       

        //Giau Panels
        private void HideAllPanel()
        {
            ShapesPanel1.Visible = false;
            TextPanel1.Visible = false;
            CanvasPanel1.Visible = false;
            BrushesPanel1.Visible = false;
            EffectsPanel1.Visible = false;
            MenuPanel1.Visible = false;
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
            if (!TextPanel1.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(TextPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
                bunifuTransition1.HideSync(TextPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
        }
        private void ShapesButton_Click(object sender, EventArgs e)
        {
            if (!ShapesPanel1.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(ShapesPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else

                bunifuTransition1.HideSync(ShapesPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);          
        }
        private void CanvasButton_Click(object sender, EventArgs e)
        {
            if (!CanvasPanel1.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(CanvasPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else           
                bunifuTransition1.HideSync(CanvasPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

       

        private void BrushesButton_Click(object sender, EventArgs e)
        {
            if (!BrushesPanel1.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(BrushesPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
            
                bunifuTransition1.HideSync(BrushesPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);      
        }

        

        private void EffectsButton_Click(object sender, EventArgs e)
        {
            if (!EffectsPanel1.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(EffectsPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
                bunifuTransition1.HideSync(EffectsPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);            
        }

        

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (!MenuPanel1.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(MenuPanel1, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
                bunifuTransition1.HideSync(MenuPanel1, false, BunifuAnimatorNS.Animation.VertSlide);
        }

        private void SketchBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDown)
            {
                gra.DrawLine(pen, old, cur);
                old = cur;
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
            }
        }
        void OneAtATime()
        {
            ZoomClicked = false;
            ZoomButton.Normalcolor = Color.Transparent;
            PanClicked = false;
            PanButton.Normalcolor = Color.Transparent;
        }
        private void SketchBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ZoomClicked)
            if (e.Delta > 0)
            {
                SketchBox.Width = (int)(SketchBox.Width * 1.1);
                SketchBox.Height = (int)(SketchBox.Height * 1.1);
                //SketchBox.Top = (int)(e.X-1.1*(e.X-SketchBox.Location.X));
                //SketchBox.Left = (int)(e.Y-1.1*(e.Y-SketchBox.Location.Y));
                SketchBox.Image = bm;
            }
            else
            {
                SketchBox.Width = (int)(SketchBox.Width / 1.1);
                SketchBox.Height = (int)(SketchBox.Height / 1.1);
                SketchBox.Image = bm;
            }
        }
        private void ZoomButton_Click(object sender, EventArgs e)
        {
            OneAtATime();
            ZoomClicked = !ZoomClicked;
            if (!ZoomClicked)
            {
                MenuButton.Focus();
                ZoomButton.Normalcolor = Color.Transparent;
            }
            else
            {
                ZoomButton.Normalcolor = Color.Silver;
                SketchBox.Focus();
            }
        }

        private void PanButton_Click(object sender, EventArgs e)
        {
            OneAtATime();
            if (!PanClicked) PanButton.Normalcolor = Color.Silver;
            else PanButton.Normalcolor = Color.Transparent;
            PanClicked = !PanClicked;
            SketchBox.Cursor = Cursors.Hand;
        }



        //xu li ve
        private void SketchBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isDown)
            {
                cur = new Point(e.Location.X, e.Location.Y);
                wid = cur.X - old.X;
                hei = cur.Y - old.Y;
                SketchBox.Refresh();
            }
            else if (isPanning)
            {               
                    cur = new Point(e.Location.X, e.Location.Y);
                    SketchBox.Left = SketchBox.Location.X + (cur.X - old.X);
                    SketchBox.Top = SketchBox.Location.Y + (cur.Y - old.Y);              
            }
        }
        private void SketchBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!PanClicked) isDown = true;
            else isPanning = true;       
            //Color c2 = Color.FromArgb((int)(colorPanel.getColor().A*0.5),(int)(colorPanel.getColor().R), (int)(colorPanel.getColor().G), (int)(colorPanel.getColor().B ));
            pen = new Pen(Color.Black, 10);
            pen.Alignment = PenAlignment.Center;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.NoAnchor, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            old = new Point(e.Location.X, e.Location.Y);
            cur = old;
        }
        private void SketchBox_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine(SketchBox.Left);
            Console.WriteLine(SketchBox.Width);
            isDown = false;
            isPanning = false;
            wid = hei = 0;
            if (SketchBox.Top <= 160) SketchBox.Top = 160;
            if (SketchBox.Left > (this.Width - 250 - SketchBox.Width)) SketchBox.Left = this.Width-250-SketchBox.Width;
        }

    }
}
