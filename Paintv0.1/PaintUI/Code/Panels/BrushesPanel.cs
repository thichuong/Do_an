using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using PaintUI.Code.Class;
using PaintUI.Code.Brushes;

namespace PaintUI
{
    public partial class BrushesPanel : UserControl
    {
        static BrushesSelection selBrush;
        static List<Point> _pts = null;
        

        Marker marker;
        Eraser eraser;
        Pencil pencil;
        CalligraphyPen calligraphy;

        static Random ran;

        static bool pickerActive;

        public BrushesPanel()
        {
            InitializeComponent();
            ran = new Random();
            
            pickerActive = false;

            ResizeHelper.SetRevolution(curBrushBtn);

            selBrush = new BrushesSelection();
            selBrush.Location = new Point(0, curBrushBtn.Location.Y + curBrushBtn.Size.Height + 10);
            selBrush.Size = new Size(Width + 20, 300);
            Controls.Add(selBrush);
            selBrush.Hide();
            selBrush.BringToFront();
            MarProp.BringToFront();

            selBrush.BrushSelected += SelBrush_BrushSelected;
            colorPanel.StateChanged += ColorPanel_StateChanged;
        }

        private void ColorPanel_StateChanged(object sender, EventArgs e)
        {
            pickerActive = !pickerActive;
        }

        private void SelBrush_BrushSelected(object sender, EventArgs e)
        {
            curBrushBtn.BackgroundImage = selBrush.getImage();

            switch (selBrush.getBrush())
            {
                case 0:
                    MarProp.BringToFront();
                    break;
                case 1:
                    EraProp.BringToFront();
                    break;
                case 2:
                    FillProp.BringToFront();
                    break;
                case 3:
                    PelProp.BringToFront();
                    break;
                case 4:
                    SprProp.BringToFront();
                    break;
                case 5:
                    CalliProp.BringToFront();
                    break;
            }

            if (selBrush.Visible)
                selBrush.Hide();
            else
                selBrush.Show();
        }

        private void curBrushBtn_Click(object sender, EventArgs e)
        {
            if (selBrush.Visible)
                selBrush.Hide();
            else
                selBrush.Show();
            
        }

        //Cac thao tac voi trang ve

        static Color color;
        static Sprayer sprayer;

        public void ProcessMouseDown(Bitmap bm, Graphics gra, Point old, Point cur)
        {
            color = Color.FromArgb(MarProp.Opacity, colorPanel.getColor1());

            switch (selBrush.getBrush())
            {
                case 0: //marker
                    marker = new Marker(color, MarProp.Thickness);
                    marker.MouseDown(gra, cur, ref _pts);
                    break;
                case 1: //eraser 
                    eraser = new Eraser(EraProp.Thickness);
                    eraser.MouseDown(gra, cur, ref _pts);
                    break;
                case 2: //fill
                    gra.CompositingMode = CompositingMode.SourceOver;
                    Color pointColor = Color.FromArgb(255, bm.GetPixel(old.X, old.Y));
                    color = Color.FromArgb(FillProp.Opacity, colorPanel.getColor2());
                    FillBucket.Fill(bm, old, pointColor, color);
                    break;
                case 3: //pencil
                    pencil = new Pencil(color, PelProp.Thickness);
                    pencil.MouseDown(gra, cur, ref _pts);
                    break;
                case 4: //spray
                    if (!pickerActive)
                    {
                        sprayer = new Sprayer();
                        sprayer.StartSpraying(gra, SprProp.Thickness, cur, color);
                    }
                    break;
                case 5:  //calligraphy pen
                    calligraphy = new CalligraphyPen(color, CalliProp.Thickness);
                    calligraphy.MouseMove(gra, old, cur, color);
                    break;
            }
        }
        
        public void ProcessMouseUp(Bitmap bm, Point cur, Stack<Bitmap> UNDO)
        {
            switch (selBrush.getBrush())
            {
                case 0:
                case 1:
                case 3:
                    _pts = new List<Point>();
                    break;
                case 4:
                    sprayer.StopSpraying();
                    break;
                case 5:
                    calligraphy.MouseUp();
                    break;
                default:
                    break;
            }

            if (!pickerActive)
            {
                UNDO.Push((Bitmap)bm.Clone());
            }else 
            {
                colorPanel.getPixelColor(bm, cur);

                pickerActive = false;
            }
        }

        public void ProcessMouseMove(Point cur, Point old, Graphics gra)
        {
            if (!pickerActive)
            {
                if (selBrush.getBrush() == 4)
                    sprayer.getLocation(cur);
                if (selBrush.getBrush() == 5)
                    calligraphy.MouseMove(gra, old, cur, color);
            }
        }

        public void ProcessPaint(Graphics gra, Point old, Point cur)
        {
            if (!pickerActive)
            {
                GraphicsPath gPath = new GraphicsPath();
                switch (selBrush.getBrush())
                {
                    case 0: //marker
                        if (_pts != null)
                        {
                            marker.Paint(gra, cur, gPath, _pts);
                        }
                        break;
                    case 1: //eraser
                        if (_pts != null)
                        {
                            eraser.Paint(gra, cur, gPath, _pts);
                        }
                        break;
                    case 3: //pencil
                        if (_pts != null)
                        {
                            pencil.Paint(gra, cur, gPath, _pts);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        
        
    }
}

