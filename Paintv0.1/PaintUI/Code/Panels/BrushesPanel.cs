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
using PaintUI.Code.Brushes;
using PaintUI.Code.Classes;

namespace PaintUI
{
    public partial class BrushesPanel : UserControl
    {
        static BrushesSelection selBrush;
        static List<Point> _pts = null;
        static Point[] points;
        Marker marker;
        Eraser eraser;
        Pencil pencil;
        CalligraphyPen calligraphy;
        
        static bool pickerActive;

        public BrushesPanel()
        {
            InitializeComponent();
            
           // ResizeHelper.SetRevolution(curBrushBtn);

            selBrush = new BrushesSelection();
            selBrush.Location = new Point(0, curBrushBtn.Location.Y + curBrushBtn.Size.Height + 10);
            selBrush.Size = new Size(Width + 20, 220);
            selBrush.BringToFront();
            selBrush.Hide();

            Controls.Add(selBrush);
            MarProp.BringToFront();

            Brushes_Label1.Text = "Marker";
            Brushes_Label1.Location = new Point(77, 8);
            curBrushBtn.Location = new Point((this.Width - curBrushBtn.Width) / 2, curBrushBtn.Location.Y);

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
                    Brushes_Label1.Text = "Marker";
                    break;
                case 1:
                    EraProp.BringToFront();
                    Brushes_Label1.Text = "Eraser";
                    break;
                case 2:
                    FillProp.BringToFront();
                    Brushes_Label1.Text = "Fill Can";
                    break;
                case 3:
                    PelProp.BringToFront();
                    Brushes_Label1.Text = "Pencil";
                    break;
                case 4:
                    SprProp.BringToFront();
                    Brushes_Label1.Text = "Spray Can";
                    break;
                case 5:
                    CalliProp.BringToFront();
                    Brushes_Label1.Text = "Calligraphy Pen";
                    break;
            }

            Brushes_Label1.Location = new Point((this.Width - Brushes_Label1.Width) / 2, Brushes_Label1.Location.Y);

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
            {
                selBrush.Show();
            }
            selBrush.BringToFront();
        }


        //Cac thao tac voi trang ve

        static Color color;
        static Sprayer sprayer;

        public void ProcessMouseDown(Bitmap bm, Graphics gra, Point old, Point cur)
        {
            if (!pickerActive)
                switch (selBrush.getBrush())
                {
                case 0: //marker
                    ModifyComponents.Graphics(gra);
                    color = Color.FromArgb(MarProp.Opacity, colorPanel.getColor1());
                    marker = new Marker(color, MarProp.Thickness* Form1.current.SketchBoxWidth() / Form1.current.NormalWidth());
                        marker.MouseDown(ref gra, cur, ref _pts);
                    points = _pts.ToArray();
                    break;
                case 1: //eraser 
                    gra.CompositingMode = CompositingMode.SourceCopy;
                    eraser = new Eraser(EraProp.Thickness * Form1.current.SketchBoxWidth() / Form1.current.NormalWidth());
                        eraser.MouseDown(ref gra, cur, ref _pts);
                    points = _pts.ToArray();
                    break;
                case 2: //fill
                    Color pointColor = Color.FromArgb(255, bm.GetPixel(old.X, old.Y));
                    color = Color.FromArgb(FillProp.Opacity, colorPanel.getColor2());
                    FillBucket.Fill(bm, old, pointColor, color);
                    break;
                case 3:
                    ModifyComponents.Graphics(gra);
                    color = Color.FromArgb(PelProp.Opacity, colorPanel.getColor1());
                    pencil = new Pencil(color, PelProp.Thickness * Form1.current.SketchBoxWidth() / Form1.current.NormalWidth());
                    pencil.MouseDown(ref gra, cur, ref _pts);
                    points = _pts.ToArray();
                    break;
                case 4:
                    color = Color.FromArgb(SprProp.Opacity, colorPanel.getColor1());
                    sprayer = new Sprayer();
                    sprayer.StartSpraying(gra, SprProp.Thickness * Form1.current.SketchBoxWidth() / Form1.current.NormalWidth(), cur, color);
                    break;
                case 5:
                    ModifyComponents.Graphics(gra);
                    color = Color.FromArgb(CalliProp.Opacity, colorPanel.getColor1());
                    calligraphy = new CalligraphyPen(color, CalliProp.Thickness * Form1.current.SketchBoxWidth() / Form1.current.NormalWidth());
                    calligraphy.MouseDown(ref gra, cur, ref _pts);
                    points = _pts.ToArray();
                    break;
                }
        }


        public bool ProcessMouseUp(Bitmap bm, Point cur)
        {
            switch (selBrush.getBrush())
            {
                case 0:
                case 1:
                case 3:
                    _pts = new List<Point>();
                    points = _pts.ToArray();
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
                return true;
            }
            else
            {
                colorPanel.getPixelColor(bm, cur);
                pickerActive = false;
                return false;
            }
            
        }

        public void ProcessMouseMove(Point cur, Point old)
        {
            if (!pickerActive)
            {
                switch (selBrush.getBrush())
                {
                    case 0: //marker
                    case 1: //eraser
                    case 3:
                    case 5:
                        _pts.Add(cur);
                        points = _pts.ToArray();
                        break;
                    case 4:
                        sprayer.getLocation(cur);
                        break;
                    default:
                        break;
                }
            }
        }

        public void ProcessPaint(Graphics gra, Point old, Point cur)
        {
            if (!pickerActive)
            {
                GraphicsPath gPath = new GraphicsPath();

                if (points != null)
                {
                    switch (selBrush.getBrush())
                    {
                        case 0: //marker
                            marker.Paint(gra, cur, gPath, points);
                            break;
                        case 1: //eraser
                            gra.CompositingMode = CompositingMode.SourceCopy;
                            eraser.Paint(gra, cur, gPath, points);
                            break;
                        case 3:
                            pencil.Paint(gra, cur, gPath, points);
                            break;
                        case 5:
                            calligraphy.Paint(gra, cur, gPath, _pts);
                            break;
                        default:
                            break;
                    }
                }   
            }
        }
        
    }
}
