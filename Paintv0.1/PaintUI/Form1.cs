using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

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

            menuPanel.BringToFront();
            SketchBox.Cursor = Cursors.Cross;
            
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

            menuPanel.NewButtonClick += MenuPanel_NewButtonClick;
            menuPanel.OpenButtonClick += MenuPanel_OpenButtonClick;
            menuPanel.SaveButtonClick += MenuPanel_SaveButtonClick;
            menuPanel.SaveAsButtonClick += MenuPanel_SaveAsButtonClick;
            
        }

        

        //Xu li cac xu kien cua menuPanel

        private void MenuPanel_SaveAsButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            
        }

        private void MenuPanel_SaveButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bmp (*.bmp)|*.bmp|Jpg (*.jpg)|*.jpg|Jpeg (*.jpeg)|*.jpeg|Png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bm.Save(sfd.FileName);
            }
        }

        private void MenuPanel_OpenButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files(*.jpg,*.jpeg, *.png, *.bmp)|*jpg; *jpeg; **png; *bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                bm = new Bitmap(SketchBox.Width, SketchBox.Height);
                gra = Graphics.FromImage(bm);
                gra.DrawImage(img, new Rectangle(0, 0, bm.Width, bm.Height));
                SketchBox.Refresh();
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
            }
        }

        private void MenuPanel_NewButtonClick(object sender, EventArgs e)
        {
            bm = new Bitmap(this.Width, this.Height);
            gra = Graphics.FromImage(bm);
            SketchBox.Refresh();
            SketchBox.BackgroundImage = (Bitmap)bm.Clone();
        }



        //Giau Panels
        private void HideAllPanel()
        {
            shapesPanel.Visible = false;
            textPanel.Visible = false;
            canvasPanel.Visible = false;
            brushesPanel.Visible = false;
            effectsPanel.Visible = false;
            menuPanel.Visible = false;
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


        //Hien thi cac Panels khi click va hover va leave
        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            BunifuTileButton button = sender as BunifuTileButton;
            button.ImageZoom = (int)(button.ImageZoom / 1.5);
        }


        private void MenuButton_MouseHover(object sender, EventArgs e)
        {
            BunifuTileButton button = sender as BunifuTileButton;
            button.ImageZoom = (int)(button.ImageZoom * 1.5);
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(menuPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            if (!textPanel.Visible)
            {
                HideAllPanel();
                textPanel.Show();
            }
            
        }
        private void ShapesButton_Click(object sender, EventArgs e)
        {
            if (!shapesPanel.Visible)
            {
                HideAllPanel();
                shapesPanel.Show();
            }
            curTool = Tools.SHAPE;
        }
        private void CanvasButton_Click(object sender, EventArgs e)
        {
            if (!canvasPanel.Visible)
            {
                HideAllPanel();
                canvasPanel.Show();
            }
          
        }

        private void BrushesButton_Click(object sender, EventArgs e)
        {
            if (!brushesPanel.Visible)
            {
                HideAllPanel();
                brushesPanel.Show();
            }
            curTool = Tools.BRUSH;
        }
        private void EffectsButton_Click(object sender, EventArgs e)
        {
            if (!effectsPanel.Visible)
            {
                HideAllPanel();
                effectsPanel.Show();
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

        
        private void SketchBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            pen = new Pen(Color.FromArgb(brushesPanel.getOpacity(), colorPanel.getColor()), brushesPanel.getThickness());
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
                    default:
                        break;
                }

            }
        }
        

        //---------------

    }
}
