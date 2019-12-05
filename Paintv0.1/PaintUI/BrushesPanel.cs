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

namespace PaintUI
{
    public partial class BrushesPanel : UserControl
    {
        static BrushesSelection selBrush;
        static List<Point> _pts = null;
        static Pen pen;
        static Random ran;
        static int distance;
        static double standarSize, penSize;

        static bool pickerActive;

        public BrushesPanel()
        {
            InitializeComponent();


            ran = new Random();

            thicknessSlide.Value = 10;
            opacitySlide.Value = 255;
            thicknessSlide.MaximumValue = 30;

            penSize = standarSize = thicknessSlide.Value;

            pen = new Pen(colorPanel.getColor1(), (float)penSize);
            pickerActive = false;

           // ResizeHelper.SetRevolution(curBrushBtn);

            selBrush = new BrushesSelection();
            selBrush.Location = new Point(0, curBrushBtn.Location.Y + curBrushBtn.Size.Height + 10);
            selBrush.Size = new Size(Width + 20, 210);
            Controls.Add(selBrush);
            selBrush.Hide();
            selBrush.BringToFront();

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
            color = Color.FromArgb(opacitySlide.Value, colorPanel.getColor1());
            pen = new Pen(color, thicknessSlide.Value);
            pen.DashStyle = DashStyle.Solid;
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

            switch (selBrush.getBrush())
            {
                case 0: //marker
                    //gra.CompositingMode = CompositingMode.SourceOver;
                    //gra.SmoothingMode = SmoothingMode.AntiAlias;
                    ModifyGra(gra);
                    gra.CompositingQuality = CompositingQuality.GammaCorrected;
                    _pts = new List<Point>();
                    _pts.Add(cur);
                    break;
                case 1: //eraser 
                    //gra.CompositingMode = CompositingMode.SourceOver;
                    //gra.SmoothingMode = SmoothingMode.AntiAlias;
                    ModifyGra(gra);
                    gra.CompositingQuality = CompositingQuality.GammaCorrected;
                    _pts = new List<Point>();
                    _pts.Add(cur);
                    break;
                case 2: //fill
                    Color pointColor = Color.FromArgb(255, bm.GetPixel(old.X, old.Y));
                    color = Color.FromArgb(opacitySlide.Value, colorPanel.getColor2());
                    FillBucket.Fill(bm, old, pointColor, color);
                    break;
                case 3:
                    break;
                case 4:
                    if (!pickerActive)
                    {
                        sprayer = new Sprayer();
                        sprayer.StartSpraying(gra, (int)pen.Width, cur, color);
                    }
                    break;
                case 5:
                    //gra.CompositingMode = CompositingMode.SourceOver;
                    //gra.SmoothingMode = SmoothingMode.AntiAlias;
                    ModifyGra(gra);
                    penSize = standarSize = thicknessSlide.Value;
                    break;
            }
        }


        public void ProcessMouseUp(Bitmap bm, Point cur, Stack<Bitmap> UNDO)
        {
            if (selBrush.getBrush() == 0 || selBrush.getBrush() == 1)
            {
                _pts = new List<Point>();
            }

            if (selBrush.getBrush() == 4)
            {
                sprayer.StopSpraying();
            }

            if (selBrush.getBrush() == 5)
            {
                penSize = standarSize;
            }

            if (!pickerActive)
            {
                UNDO.Push((Bitmap)bm.Clone());
            }

            if (pickerActive)
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
                {
                    distance = Convert.ToInt32((cur.X - old.X) * (cur.X - old.X) + (cur.Y - old.Y) * (cur.Y - old.Y)) / 10;

                    if (distance > 0)
                    {
                        if (distance < 15 && penSize <= standarSize)
                            penSize += standarSize / 20;
                        else if (distance >= 2 && penSize > 1)
                            penSize -= standarSize / 20;
                    }
                    gra.SmoothingMode = SmoothingMode.AntiAlias;
                    pen = new Pen(color, (float)penSize);
                    pen.DashStyle = DashStyle.Solid;
                    pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    gra.DrawLine(pen, old, cur);
                }
                if(selBrush.getBrush()==0 || selBrush.getBrush()==1)
                    _pts.Add(cur);
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
                            //gra.CompositingMode = CompositingMode.SourceOver;
                            //gra.SmoothingMode = SmoothingMode.AntiAlias;
                            ModifyGra(gra);
                            
                            gPath.AddLines(_pts.ToArray());
                            pen.LineJoin = LineJoin.Round;
                            gra.CompositingMode = CompositingMode.SourceOver;
                            gra.DrawPath(pen, gPath);
                        }
                        break;
                    case 1: //eraser
                        if (_pts != null)
                        {
                            gra.CompositingMode = CompositingMode.SourceCopy;
                            gra.SmoothingMode = SmoothingMode.None;
                            
                            gPath.AddLines(_pts.ToArray());

                            pen = new Pen(Color.Transparent, thicknessSlide.Value);
                            pen.LineJoin = LineJoin.Round;

                            gra.CompositingMode = CompositingMode.SourceCopy;
                            gra.DrawPath(pen, gPath);
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
        }

        private void ModifyGra(Graphics gra)
        {
            gra.CompositingMode = CompositingMode.SourceOver;
            gra.SmoothingMode = SmoothingMode.AntiAlias;
        }


    }
}
