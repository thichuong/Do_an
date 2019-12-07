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
using PaintUI.Code.Class;

namespace PaintUI
{
    public partial class Form1 : Form
    {
        enum Tools { BRUSH, SHAPE};
        Tools curTool;
        
        Bitmap bm, temp, visionBM;
        Graphics gra;
        Point old, cur;
<<<<<<< HEAD
        Point pOld, startPoint, oldLocation;

        int wid, hei;
        
        bool isDown, isDragged, isSaved, isChanged;

        Stack<Bitmap> UNDO, REDO;
        

=======
        Point pOld, startPoint, oldLocation,RecStartPoint,
            RecEndPoint,RecVeryLast;
        int numberofLayerRemoved = -1;
        int wid, hei;
        List<Bitmap> RemovedLayer = new List<Bitmap>();
        List<Bitmap> templistBM = new List<Bitmap>();
        bool isDown, isDragged, isSaved, isChanged,PanClicked,isPanning,SelectClicked,isSelecting;
        bool RegionSelected = false;
        StackListBitmap UNDO, REDO;
        Rectangle SelectionRec;
        Bitmap SelectionBitmap;
        Graphics SelectionGraphics;
        Graphics graphics;
>>>>>>> parent of b0b5c2e... update UNDO and REDO
        public Form1()
        {
            InitializeComponent();
           
            HideAllPanel();
            brushesPanel.Show();

            {
                bm = new Bitmap(SketchBox.Width, SketchBox.Height, SketchBox.CreateGraphics());
                gra = Graphics.FromImage(bm);

                isDown = isSaved = isChanged = isDragged = false;
                
                menuPanel.BringToFront();
                SketchBox.Cursor = Cursors.Cross;

<<<<<<< HEAD
                UNDO = new Stack<Bitmap>();
                UNDO.Push((Bitmap)bm.Clone());
                REDO = new Stack<Bitmap>();
=======
                UNDO = new StackListBitmap();
                UNDO.Push(LayerList, bm);
                REDO = new StackListBitmap();
>>>>>>> parent of b0b5c2e... update UNDO and REDO
            }
            

            {
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

                gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                
            }
            
            {
                menuPanel.NewButtonClick += MenuPanel_NewButtonClick;
                menuPanel.OpenButtonClick += MenuPanel_OpenButtonClick;
                menuPanel.SaveButtonClick += MenuPanel_SaveButtonClick;
                menuPanel.SaveAsButtonClick += MenuPanel_SaveAsButtonClick;
                menuPanel.ExitButtonClick += MenuPanel_ExitButtonClick;
            }

            {
                LeftTopPanel.Visible = false;
                LeftBottomPanel.Visible = false;
                RightTopPanel.Visible = false;
                RightBottomPanel.Visible = false;
            }
        }

<<<<<<< HEAD
=======
        //Layer Actions
        private void LayerPanel_LayerRemoved(object sender, EventArgs e)
        {         
            numberofLayerRemoved++;            
            RemovedLayer.Add(LayerList[layerPanel.removedLayerIndex]);
            gra = Graphics.FromImage(bm);
            LayerList[layerPanel.removedLayerIndex] = bm;
            currentLayerBitmap = bm;
            Console.WriteLine("new list" + NewList().Count);
            Console.WriteLine("Currently on bm");
        }

        private void LayerPanel_BaseLayerClicked(object sender, EventArgs e)
        {                  
            Console.WriteLine("currently on bm");
            currentLayerBitmap = bm;
            gra = Graphics.FromImage(currentLayerBitmap);
            LayerDrawer();
            SketchBoxVisionImage(temp);
        }

        private void LayerPanel_AddLayerClicked(object sender, EventArgs e)
        {            
            bitmap1 = new Bitmap(SketchBox.Width, SketchBox.Height);           
            LayerList.Add(bitmap1);
        }

        private void PanButton_Click(object sender, EventArgs e)
        {
            PanClicked = !PanClicked;
        }
        private void LayerPanel_LayerClicked(object sender, EventArgs e)
        {
            if (!layerPanel.rightclicked)
            {               
                Button bn = sender as Button;
                int LayerIndex = Convert.ToInt32(bn.Name);
                currentLayerBitmap = LayerList[LayerIndex];
                gra = Graphics.FromImage(currentLayerBitmap);
                Console.WriteLine("currently on: " + LayerIndex);
                LayerDrawer();
                SketchBoxVisionImage(temp);
            }
            
        }
        private List<Bitmap> NewList()
        {
            List<Bitmap> ListException = LayerList.Except(RemovedLayer).ToList();
            return ListException;
        }
        //End of Layer Actions
>>>>>>> parent of b0b5c2e... update UNDO and REDO

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
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
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



        //Xu li cac xu kien cua menuPanel

        string path = "";
        
        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bmp (*.bmp)|*.bmp|Jpg (*.jpg)|*.jpg|Jpeg (*.jpeg)|*.jpeg|Png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                Bitmap savebm = new Bitmap(SketchBox.Width, SketchBox.Height);
                Graphics graphics = Graphics.FromImage(savebm);
                graphics.Clear(SketchBox.BackColor);
                graphics.DrawImage(visionBM, 0, 0, SketchBox.Width, SketchBox.Height);
                savebm.Save(path);
                titleLb.Text = Path.GetFileNameWithoutExtension(path) + " - Skuitch";
                isSaved = true;
                isChanged = false;
            }
        }

        private void Save()
        {
            if (!isSaved)
            {
                SaveAs();
            }
            else
            {
                if (path != "")
                {
                    Bitmap savebm = new Bitmap(SketchBox.Width, SketchBox.Height);
                    Graphics graphics = Graphics.FromImage(savebm);
                    graphics.Clear(SketchBox.BackColor);
                    graphics.DrawImage(visionBM, 0, 0, SketchBox.Width, SketchBox.Height);
                    savebm.Save(path);
                    isChanged = false;
                }
            }
        }

        private void New()
        {
            bm = new Bitmap(SketchBox.Width, SketchBox.Height);
            gra = Graphics.FromImage(bm);
            SketchBox.Refresh();
<<<<<<< HEAD
            SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
=======
            SketchBoxVisionImage(bm);
>>>>>>> parent of b0b5c2e... update UNDO and REDO
            while (UNDO.Count() > 1)
            {
                UNDO.Pop();
            }
            while (REDO.Count() > 0)
            {
                REDO.Pop();
            }
            titleLb.Text = "Untitled - Skuitch";
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
                titleLb.Text = Path.GetFileNameWithoutExtension(path) + " - Skuitch";
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
            SaveAs();
        }

        private void MenuPanel_SaveButtonClick(object sender, EventArgs e)
        {
            Save();
        }

        private void MenuPanel_OpenButtonClick(object sender, EventArgs e)
        {
            if (isChanged)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveAs();
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

        //Xu li cac xu kien cua effectPanel
        public void Effect_change(Color color,Color colorpanelCavas)
        {
            SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
            panelCavas.BackColor = colorpanelCavas;
        }
      



        

        //Hien thi cac Panels khi click va hover va leave


        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (!menuPanel.Visible)
                bunifuTransition1.ShowSync(menuPanel, false, BunifuAnimatorNS.Animation.VertSlide);
            else
                bunifuTransition1.HideSync(menuPanel, false, BunifuAnimatorNS.Animation.VertSlide);
            
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
                LeftTopPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y - 10);
                RightBottomPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y + SketchBox.Height);
                RightTopPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y - 10);
                LeftBottomPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y + SketchBox.Height);
                if (!canvasPanel.ShowCheckBox)
                {
                    LeftTopPanel.Visible = false;
                    LeftBottomPanel.Visible = false;
                    RightTopPanel.Visible = false;
                    RightBottomPanel.Visible = false;
                }
                else
                {
                    LeftTopPanel.Visible = true;
                    LeftBottomPanel.Visible = true;
                    RightTopPanel.Visible = true;
                    RightBottomPanel.Visible = true;
                }
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

        private void UndoButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if(UNDO.Count>1)
            {
                REDO.Push((Bitmap)UNDO.Pop().Clone());
                bm = (Bitmap)UNDO.Peek().Clone();
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
                gra = Graphics.FromImage(bm);
=======
            if(UNDO.Count()>1)
            {
                REDO.Push(UNDO.Pop(), bm);
                bm = UNDO.PeekBitmap();
                currentLayerBitmap = bm;
                LayerList = UNDO.Peek();
                SketchBoxVisionImage(currentLayerBitmap);
                gra = Graphics.FromImage(currentLayerBitmap);
>>>>>>> parent of b0b5c2e... update UNDO and REDO
                isChanged = true;
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if(REDO.Count>0)
            {
                UNDO.Push((Bitmap)REDO.Pop().Clone());
                bm = (Bitmap)UNDO.Peek().Clone();
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
                gra = Graphics.FromImage(bm);
                isChanged = true;
            }
        }
        
=======
            if (REDO.Count() > 0)
            {
                bm = (Bitmap)REDO.PeekBitmap().Clone();
                LayerList = REDO.Peek();
                UNDO.Push(REDO.Pop(),bm);
                currentLayerBitmap = bm;
                SketchBoxVisionImage(currentLayerBitmap);
                gra = Graphics.FromImage(currentLayerBitmap);
                isChanged = true;
            }
        }


        private void LayerDrawer()
        {
            temp = new Bitmap(SketchBox.Width, SketchBox.Height);
            graphics = Graphics.FromImage(temp);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawImage(currentLayerBitmap, 0, 0);
        }

>>>>>>> parent of b0b5c2e... update UNDO and REDO
        //Cac su kien voi mouse
        private void SketchBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                cur = new Point(e.Location.X, e.Location.Y);
                wid = cur.X - old.X;
                hei = cur.Y - old.Y;

                if (curTool == Tools.BRUSH)
                {
                    brushesPanel.ProcessMouseMove(cur, old, gra);
                }
                SketchBox.Refresh();
            }
        }

        private void SketchBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            if (curTool == Tools.SHAPE)
            {
                shapesPanel.ProcessMouseUp(SketchBox, bm, gra, old, cur, new Size(wid, hei), UNDO);
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
            }
            if(curTool==Tools.BRUSH)
            {
                brushesPanel.ProcessPaint(gra, old, cur);
                brushesPanel.ProcessMouseUp(bm, cur, UNDO);
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
            }
            wid = hei = 0;
            
<<<<<<< HEAD
            while(REDO.Count>0)
=======
            //Them vao stack UNDO khi het net ve
            UNDO.Push(LayerList,bm);
            while (REDO.Count() > 0)
>>>>>>> parent of b0b5c2e... update UNDO and REDO
            {
                REDO.Pop();
            }
        }

        private void SketchBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (!isDown)
                {
                    old = new Point(e.Location.X, e.Location.Y);
                    cur = old;
<<<<<<< HEAD
                    if (curTool == Tools.BRUSH)
                    {
                        brushesPanel.ProcessMouseDown(bm, gra, old, cur);
                        SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
                    }
=======
                    gra = Graphics.FromImage(currentLayerBitmap);
                    brushesPanel.ProcessMouseDown(currentLayerBitmap, gra, old, cur);
                    gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                    gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    SketchBoxVisionImage(currentLayerBitmap);
                }
               
                if (PanClicked) isPanning = true;
                else if (SelectClicked&&!RegionSelected)
                {
                    isSelecting = true;
                    RecStartPoint = e.Location;
                }
                else if (!RegionSelected) isDown = true;
               
                isChanged = true;
>>>>>>> parent of b0b5c2e... update UNDO and REDO

                    isDown = true;
                    isChanged = true;
                }
            }
        }

        private void SketchBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDown)
            {
                temp = new Bitmap(SketchBox.Width, SketchBox.Height);
                Graphics graphics = Graphics.FromImage(temp);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawImage(bm, 0, 0, SketchBox.Width, SketchBox.Height);
                switch (curTool)
                {
                    case Tools.BRUSH:
                        brushesPanel.ProcessPaint(graphics, old, cur);
                        old = cur;
                        SketchBoxEffect.SketchBoxVisionImage(temp, SketchBox, effectsPanel, visionBM);
                        break;
                    case Tools.SHAPE:
                        shapesPanel.ProcessPaint(SketchBox, bm, graphics, old, cur, new Size(wid, hei));
                        SketchBoxEffect.SketchBoxVisionImage(temp, SketchBox, effectsPanel, visionBM);
                        break;
                    default:
                        break;
                }
            }
        }
        
<<<<<<< HEAD
        
=======

        public void SketchBoxVisionImage(Bitmap bmp)
        {  
            Bitmap effectBM = new Bitmap(SketchBox.Width, SketchBox.Height);
            Graphics  vGra = Graphics.FromImage(effectBM);
             vGra.Clear(effectsPanel.color);
            visionBM = new Bitmap(SketchBox.Width, SketchBox.Height);
             vGra = Graphics.FromImage(visionBM);
            if (bm!= currentLayerBitmap)
                 vGra.DrawImage(bm, 0, 0);
            else
                 vGra.DrawImage(bmp, 0, 0, SketchBox.Width, SketchBox.Height);
            for (int i = 0; i < NewList().Count; i++)
                if(NewList()[i]!=currentLayerBitmap)
                     vGra.DrawImage(NewList()[i], 0, 0);
                else
                     vGra.DrawImage(bmp, 0, 0);
             vGra.DrawImage(effectBM, 0, 0, SketchBox.Width, SketchBox.Height);
            SketchBox.BackgroundImage = (Bitmap)visionBM.Clone();
        }

>>>>>>> parent of b0b5c2e... update UNDO and REDO

        public void SketchBoxShowResizepanel()
        {
            if (!canvasPanel.ShowCheckBox)
            {
                LeftTopPanel.Visible = false;
                LeftBottomPanel.Visible = false;
                RightTopPanel.Visible = false;
                RightBottomPanel.Visible = false;
            }
            else
            {
                LeftTopPanel.Visible = true;
                LeftBottomPanel.Visible = true;
                RightTopPanel.Visible = true;
                RightBottomPanel.Visible = true;
            }
        }

        public void SketchBoxTransparent()
        {
            if(SketchBox.BackColor==Color.Transparent)
            {
                SketchBox.BackColor = Color.White;
            }
            else
            {
                SketchBox.BackColor = Color.Transparent;
            }
        }

        private void SketchBox_SizeChanged(object sender, EventArgs e)
        {
            canvasPanel.setCanvasText(SketchBox);
            SketchBox.Location = new Point(panelCavas.Width / 2 - SketchBox.Width / 2, panelCavas.Height / 2 - SketchBox.Height / 2);
            LeftTopPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y - 10);
            RightBottomPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y + SketchBox.Height);
            RightTopPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y - 10);
            LeftBottomPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y + SketchBox.Height);
        }

        private void SketchBox_LocationChanged(object sender, EventArgs e)
        {
            LeftTopPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y - 10);
            RightBottomPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y + SketchBox.Height);
            RightTopPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y - 10);
            LeftBottomPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y + SketchBox.Height);
        }
      

        //---------------
        //Resize SketchBox
        public void resizeSketchBox()
        {
            if(canvasPanel.getCanvasTextWidth()>100 && canvasPanel.getCanvasTextHeight()>100)
            {
                temp = (Bitmap)bm.Clone();
                SketchBox.Width = canvasPanel.getCanvasTextWidth();
                SketchBox.Height = canvasPanel.getCanvasTextHeight();
                bm = new Bitmap(SketchBox.Width, SketchBox.Height);
                gra = Graphics.FromImage(bm);
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
            }
            else
            {
                canvasPanel.setCanvasText(SketchBox);
            }
           
        }
<<<<<<< HEAD

=======
        private List<Bitmap> tempBitmaps()
        {
            temp =(Bitmap) bm.Clone();
            Graphics tempGra;
            List<Bitmap> bitmaps = new List<Bitmap>();
            for (int i = 0; i < NewList().Count; i++)
            {
                Bitmap bitmap = (Bitmap)NewList()[i].Clone();
                bitmaps.Add(bitmap);
            }
            return bitmaps;
        }
        private void tempBitmapsRisize()
        {
            Graphics tempGra;
            Bitmap bitmap = new Bitmap(SketchBox.Width, SketchBox.Height);
            bm=new Bitmap(SketchBox.Width, SketchBox.Height);
            gra = Graphics.FromImage(bm);
            gra.CompositingQuality = CompositingQuality.GammaCorrected;
            gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
            
            for (int i = 0; i < NewList().Count; i++)
            {
                bitmap = new Bitmap(SketchBox.Width, SketchBox.Height); ;
                tempGra = Graphics.FromImage(bitmap);
                tempGra.CompositingQuality = CompositingQuality.GammaCorrected;
                tempGra.DrawImage(templistBM[i], 0, 0,SketchBox.Width,SketchBox.Height);
                LayerList[i]= (Bitmap)bitmap.Clone();
            }
            SketchBoxVisionImage(bm);
        }
>>>>>>> parent of b0b5c2e... update UNDO and REDO
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
               
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
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
                
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
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
               
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
                panelCavas.Refresh();
            }
        }

        private void RightTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void RightBottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            temp = (Bitmap)bm;
            isDragged = true;
        }

        private void RightBottomPanel_MouseMove(object sender, MouseEventArgs e)
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
            
                gra.DrawImage(temp, 0, 0, SketchBox.Width, SketchBox.Height);
                SketchBoxEffect.SketchBoxVisionImage(bm, SketchBox, effectsPanel, visionBM);
                panelCavas.Refresh();
            }
          
        }

        private void RightBottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void panelCavas_SizeChanged(object sender, EventArgs e)
        {
            SketchBox.Location = new Point(panelCavas.Width / 2 - SketchBox.Width / 2, panelCavas.Height / 2 - SketchBox.Height / 2);
            LeftTopPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y - 10);
            RightBottomPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y + SketchBox.Height);
            RightTopPanel.Location = new Point(SketchBox.Location.X + SketchBox.Width, SketchBox.Location.Y - 10);
            LeftBottomPanel.Location = new Point(SketchBox.Location.X - 10, SketchBox.Location.Y + SketchBox.Height);
        }
        
        
        //Code resize winform
        
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopPanelDragged = false;

        bool isRightBottomPanelDragged = false;
        bool isLeftBottomPanelDragged = false;
        bool isRightTopPanelDragged = false;
        bool isLeftTopPanelDragged = false;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.Y <= 0 || e.Y < 0)
            {
                isTopPanelDragged = false;
                this.Location = new Point(this.Location.X,10);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isTopPanelDragged = true;
                }
                else
                {
                    isTopPanelDragged = false;
                }
            }

        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                    this.Refresh();
                }
            }
        }
        
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }
        
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                    }
                    this.Refresh();
                }
            }
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }
        
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                }
                this.Refresh();
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }

        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
                this.Refresh();
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }

        private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = true;
        }

        private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightBottomPanelDragged)
            {
                if (this.Width < 100 || this.Height < 50)
                {
                    this.Width = 100;
                    this.Height = 50;
                    isRightBottomPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                    this.Height = this.Height + e.Y;
                }
                this.Refresh();
            }
        }

        private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = false;
        }

        private void LeftBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = true;
        }

        private void LeftBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftBottomPanelDragged || this.Height < 50)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        this.Height = 50;
                        isLeftBottomPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Height = this.Height + e.Y;
                    }
                    this.Refresh();
                }
            }
        }

        private void LeftBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = false;
        }

        private void RightTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = true;
        }

        private void RightTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y || e.X < this.Location.X)
            {
                if (isRightTopPanelDragged)
                {
                    if (this.Height < 50 || this.Width < 100)
                    {
                        this.Height = 50;
                        this.Width = 100;
                        isRightTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                        this.Width = this.Width + e.X;
                    }
                    this.Refresh();
                }
            }
        }

        private void RightTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = false;
        }

        private void LeftTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = true;
        }

        private void LeftTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X || e.Y < this.Location.Y)
            {
                if (isLeftTopPanelDragged)
                {
                    if (this.Width < 100 || this.Height < 50)
                    {
                        this.Width = 100;
                        this.Height = 100;
                        isLeftTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                    this.Refresh();
                }
            }

        }

        private void LeftTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = false;
        }

       
    }
}
