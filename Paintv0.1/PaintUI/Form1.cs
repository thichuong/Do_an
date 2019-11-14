using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.IO;

namespace PaintUI
{
    public partial class Form1 : Form
    {
        //Khai bao bien
        enum Tools { BRUSH, SHAPE, FILLBUCKET, ERASER, SELECT, TEXT};

        Tools curTool;
        Pen pen;
        Bitmap bm;
        Graphics gra;
        Bitmap temp;
        Point old, cur;
        SolidBrush eraser, fillColor;

        bool isDown;
        int wid, hei;
        int penSize;
        
        Point pOld, startPoint, oldLocation;
        bool isDragged = false;
        bool isSaved = false;
        bool isChanged = false;
        

        Stack<Bitmap> UNDO;
        Stack<Bitmap> REDO;
        


        public Form1()
        {
            InitializeComponent();

            HideAllPanel();
            brushesPanel.Show();

            //Khoi tao bien
            {
                this.Size = new Size(1000, 800);
                this.Text = "Untitled";
                penSize = 10;
                pen = new Pen(Color.Black, penSize);
                pen.DashStyle = DashStyle.Dash;
                pen.Alignment = PenAlignment.Center;
                bm = new Bitmap(SketchBox.Width, SketchBox.Height, SketchBox.CreateGraphics());
                gra = Graphics.FromImage(bm);
                gra.Clear(Color.White);
              

                isDown = false;
                curTool = Tools.BRUSH;

                menuPanel.BringToFront();
                SketchBox.Cursor = Cursors.Cross;

                UNDO = new Stack<Bitmap>();
                REDO = new Stack<Bitmap>();
                UNDO.Push((Bitmap)bm.Clone());
            }

            //Modify stroke
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.RoundAnchor, System.Drawing.Drawing2D.LineCap.RoundAnchor, System.Drawing.Drawing2D.DashCap.Round);


            //Smoothing
            {
                gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                gra.Clear(Color.White);
            }

            //Bat su kien cho cac panel
            {
                menuPanel.NewButtonClick += MenuPanel_NewButtonClick;
                menuPanel.OpenButtonClick += MenuPanel_OpenButtonClick;
                menuPanel.SaveButtonClick += MenuPanel_SaveButtonClick;
                menuPanel.SaveAsButtonClick += MenuPanel_SaveAsButtonClick;
                menuPanel.ExitButtonClick += MenuPanel_ExitButtonClick;
                

                LeftTopPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y - 10);
                RightBottomPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y + SketchBox.Height);
                RightTopPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y - 10);
                LeftBottomPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y + SketchBox.Height);
                
            }
        }



        //Xu li cac xu kien cua menuPanel
        string path = "";

        private void Save()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bmp (*.bmp)|*.bmp|Jpg (*.jpg)|*.jpg|Jpeg (*.jpeg)|*.jpeg|Png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                bm.Save(path);
                this.Text = Path.GetFileNameWithoutExtension(path);
                isSaved = true;
                isChanged = false;
            }
        }

        private void New()
        {
            bm = new Bitmap(this.Width, this.Height);
            gra = Graphics.FromImage(bm);
            SketchBox.Refresh();
            SketchBox.BackgroundImage = (Bitmap)bm.Clone();
            while (UNDO.Count() > 1)
            {
                UNDO.Pop();
            }
            while (REDO.Count() > 0)
            {
                REDO.Pop();
            }
            this.Text = "Untitled";
            path = "";
            isSaved = false;
            isChanged = false;
        }

        private void Open()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files(*.jpg,*.jpeg, *.png, *.bmp)|*jpg; *jpeg; *png; *bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                this.Text = Path.GetFileNameWithoutExtension(path);
                Image img = Image.FromFile(path);
                bm = new Bitmap(SketchBox.Width, SketchBox.Height);
                gra = Graphics.FromImage(bm);
                gra.DrawImage(img, new Rectangle(0, 0, bm.Width, bm.Height));
                SketchBox.Refresh();
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                isSaved = true;
                isChanged = false;
            }
        }

        private void MenuPanel_SaveAsButtonClick(object sender, EventArgs e)
        {
            Save();
        }

        private void MenuPanel_SaveButtonClick(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                Save();
            }
            else
            {
                if (path != "")
                {
                    bm.Save(path);
                    isChanged = false;
                }
            }
        }

        private void MenuPanel_OpenButtonClick(object sender, EventArgs e)
        {
            if (isChanged)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
                if (result != DialogResult.Cancel)
                {
                    Open();
                }
            }
            else Open();
            
        }

        private void MenuPanel_NewButtonClick(object sender, EventArgs e)
        {
            if (isChanged)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
                if (result != DialogResult.Cancel)
                {
                    New();
                }
            }
            else New();
            
        }

        private void MenuPanel_ExitButtonClick(object sender, EventArgs e)
        {
            if (isChanged)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
                if (result == DialogResult.Yes || result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else Application.Exit();
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
            LeftTopPanel.Visible = false;
            LeftBottomPanel.Visible = false;
            RightTopPanel.Visible = false;
            RightBottomPanel.Visible = false;
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
            curTool = Tools.TEXT;
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
                LeftTopPanel.Visible = true;
                LeftBottomPanel.Visible = true;
                RightTopPanel.Visible = true;
                RightBottomPanel.Visible = true;
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

            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
        }

        private void EffectsButton_Click(object sender, EventArgs e)
        {
            if (!effectsPanel.Visible)
            {
                HideAllPanel();
                effectsPanel.Show();
            }

        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if(UNDO.Count>1)
            {
                REDO.Push((Bitmap)UNDO.Pop().Clone());
                bm = (Bitmap)UNDO.Peek().Clone();
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                gra = Graphics.FromImage(bm);
                isChanged = true;
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if(REDO.Count>0)
            {
                UNDO.Push((Bitmap)REDO.Pop().Clone());
                bm = (Bitmap)UNDO.Peek().Clone();
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                gra = Graphics.FromImage(bm);
                isChanged = true;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            curTool = Tools.SELECT;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            curTool = Tools.FILLBUCKET;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            curTool = Tools.ERASER;
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
            if (curTool == Tools.SHAPE)
            {
                shapesPanel.DrawShapes(SketchBox, bm, gra, old, cur, new Size(wid, hei), pen, fillColor);
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
            }

            

            wid = hei = 0;

            //Them vao stack UNDO khi het net ve
            UNDO.Push((Bitmap)bm.Clone());
            while(REDO.Count>0)
            {
                REDO.Pop();
            }
        }

        private void SketchBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Color c2 = Color.FromArgb((int)(colorPanel.getColor1().A),(int)(colorPanel.getColor1().R), (int)(colorPanel.getColor1().G), (int)(colorPanel.getColor1().B ));
            Color c2 = Color.FromArgb(brushesPanel.getOpacity(), (int)(colorPanel.getColor1().R), (int)(colorPanel.getColor1().G), (int)(colorPanel.getColor1().B));
            pen = new Pen(c2, brushesPanel.getThickness());
            pen.DashStyle = DashStyle.Solid;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            fillColor = eraser = new SolidBrush(colorPanel.getColor2());

            old = new Point(e.Location.X, e.Location.Y);
            cur = old;

            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gra.CompositingQuality = CompositingQuality.GammaCorrected;


            if (curTool == Tools.FILLBUCKET)
            {
                FillBucket bucket = new FillBucket();
                bucket.Fill(bm, old, bm.GetPixel(old.X, old.Y), pen.Color);

                bucket.Fill(bm, old, bm.GetPixel(old.X, old.Y), pen.Color);
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
            }

            if(curTool==Tools.BRUSH)
            {
                gra.FillEllipse(pen.Brush, cur.X - brushesPanel.getThickness() / 2, cur.Y - brushesPanel.getThickness() / 2, brushesPanel.getThickness(), brushesPanel.getThickness());
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
            }

            isChanged = true;
            isDown = true;
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
                        shapesPanel.DrawShapes(SketchBox, bm, e.Graphics, old, cur, new Size(wid, hei), pen, fillColor);
                        break;
                    case Tools.ERASER:
                        gra.FillRectangle(eraser, cur.X - brushesPanel.getThickness() / 2, cur.Y - brushesPanel.getThickness() / 2, brushesPanel.getThickness(), brushesPanel.getThickness());
                        Pen temp = new Pen(eraser.Color, brushesPanel.getThickness());
                        temp.SetLineCap(System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.DashCap.Round);
                        gra.DrawLine(temp, old, cur);
                        old = cur;
                        SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                        break;
                    default:
                        break;
                }
            }
        }

        private void SketchBox_SizeChanged(object sender, EventArgs e)
        {
            SketchBox.Location = new Point(panelCavas.Width / 2 - SketchBox.Width / 2, panelCavas.Height / 2 - SketchBox.Height / 2);
            LeftTopPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y - 10);
            RightBottomPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y + SketchBox.Height);
            RightTopPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y - 10);
            LeftBottomPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y + SketchBox.Height);
        }

        private void SketchBox_LocationChanged(object sender, EventArgs e)
        {
            //LeftTopPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y - 10);
            //RightBottomPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y + SketchBox.Height);
            //RightTopPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y - 10);
            //LeftBottomPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y + SketchBox.Height);
        }
      
        //---------------
        //Resize SketchBox

        private void LeftTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            temp = (Bitmap)bm;
            isDragged = true;
        }

        private void LeftTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {

                pOld = e.Location;
                oldLocation = SketchBox.Location;
                if (LeftTopPanel.Location.X - startPoint.X + pOld.X < panelCavas.Width / 2 - 50
                    && LeftTopPanel.Location.Y - startPoint.Y + pOld.Y < panelCavas.Height / 2 - 50)
                {
                    LeftTopPanel.Location = new Point(LeftTopPanel.Location.X - startPoint.X + pOld.X, LeftTopPanel.Location.Y - startPoint.Y + pOld.Y);
                    SketchBox.Location = new Point(oldLocation.X - startPoint.X + pOld.X, oldLocation.Y - startPoint.Y + pOld.Y);
                    SketchBox.Size = new Size(SketchBox.Width + startPoint.X - pOld.X, SketchBox.Height + startPoint.Y - pOld.Y);
                }
                bm = new Bitmap(SketchBox.Width, SketchBox.Height);
                gra = Graphics.FromImage(bm);
                gra.Clear(Color.White);
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                panelCavas.Refresh();
            }
        }

        private void LeftTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void LeftBottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            temp = (Bitmap)bm;
            isDragged = true;
        }

        private void LeftBottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {

                pOld = e.Location;
                oldLocation = SketchBox.Location;
                if (LeftBottomPanel.Location.X - startPoint.X + pOld.X < panelCavas.Width / 2 - 50
                  && LeftBottomPanel.Location.Y - startPoint.Y + pOld.Y > panelCavas.Height / 2 + 50)
                {
                    LeftBottomPanel.Location = new Point(LeftBottomPanel.Location.X - startPoint.X + pOld.X, LeftBottomPanel.Location.Y - startPoint.Y + pOld.Y);
                    SketchBox.Location = new Point(oldLocation.X - startPoint.X + pOld.X, oldLocation.Y);
                    SketchBox.Size = new Size(SketchBox.Width + startPoint.X - pOld.X, SketchBox.Height - startPoint.Y + pOld.Y);
                }
                bm = new Bitmap(SketchBox.Width, SketchBox.Height);
                gra = Graphics.FromImage(bm);
                gra.Clear(Color.White);
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                panelCavas.Refresh();
            }
        }

        private void LeftBottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;

        }

        private void RightTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            temp = (Bitmap)bm;
            isDragged = true;
        }

        private void RightTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                pOld = e.Location;
                oldLocation = SketchBox.Location;
                if (RightTopPanel.Location.X - startPoint.X + pOld.X > panelCavas.Width / 2 + 50
                   && RightTopPanel.Location.Y - startPoint.Y + pOld.Y < panelCavas.Height / 2 - 50)
                {
                    RightTopPanel.Location = new Point(RightTopPanel.Location.X - startPoint.X + pOld.X, RightTopPanel.Location.Y - startPoint.Y + pOld.Y);
                    SketchBox.Location = new Point(oldLocation.X, oldLocation.Y - startPoint.Y + pOld.Y);
                    SketchBox.Size = new Size(SketchBox.Width - startPoint.X + pOld.X, SketchBox.Height + startPoint.Y - pOld.Y);
                }

                bm = new Bitmap(SketchBox.Width, SketchBox.Height);
                gra = Graphics.FromImage(bm);
                gra.Clear(Color.White);
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                panelCavas.Refresh();
            }
        }

        private void RightTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            temp = (Bitmap)bm;
            isDragged = true;
        }

        private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                pOld = e.Location;
                if (RightBottomPanel.Location.X - startPoint.X + pOld.X > panelCavas.Width / 2 + 50
                    && RightBottomPanel.Location.Y - startPoint.Y + pOld.Y > panelCavas.Height / 2 + 50)
                {
                    RightBottomPanel.Location = new Point(RightBottomPanel.Location.X - startPoint.X + pOld.X, RightBottomPanel.Location.Y - startPoint.Y + pOld.Y);
                    SketchBox.Size = new Size(SketchBox.Width - startPoint.X + pOld.X, SketchBox.Height - startPoint.Y + pOld.Y);
                }

                bm = new Bitmap(SketchBox.Width, SketchBox.Height);
                gra = Graphics.FromImage(bm);
                gra.Clear(Color.White);
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBox.BackgroundImage = (Bitmap)bm.Clone();
                panelCavas.Refresh();
            }
          
        }

        private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void panelCavas_SizeChanged(object sender, EventArgs e)
        {
            SketchBox.Location = new Point(panelCavas.Width / 2 - SketchBox.Width / 2, panelCavas.Height / 2 - SketchBox.Height / 2);
            LeftTopPanel.Location = new Point(SketchBox.Location.X - 22, SketchBox.Location.Y - 22);
            RightBottomPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y + SketchBox.Height);
            RightTopPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y - 22);
            LeftBottomPanel.Location = new Point(SketchBox.Location.X - 22, SketchBox.Location.Y + SketchBox.Height);
        }
    }
}
