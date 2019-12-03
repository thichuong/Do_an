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
        BrushesSelection selBrush;
        List<Point> _pts = null;
        Pen pen;
        Random ran;

        bool pickerActive;
        bool spraying;
       
        public BrushesPanel()
        {
            InitializeComponent();

            pen = new Pen(colorPanel.getColor1(), thicknessSlide.Value);
            pickerActive = false;
            spraying = false;

            ran = new Random();

            thicknessSlide.Value = 10;
            opacitySlide.Value = 255;
            thicknessSlide.MaximumValue = 30;

            ResizeHelper.SetRevolution(curBrushBtn);

            selBrush = new BrushesSelection();
            selBrush.Location = new Point(0, curBrushBtn.Location.Y + curBrushBtn.Size.Height + 10);
            selBrush.Size = new Size(Width + 20, 0);
            Controls.Add(selBrush);
            selBrush.Show();
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
            Slider slider = new Slider();
            slider.Sliding(selBrush);
        }

        private void curBrushBtn_Click(object sender, EventArgs e)
        {
            Slider slider = new Slider();
            slider.Sliding(selBrush);
        }


        //Cac thao tac voi trang ve

        Color color;
        public void ProcessMouseMove(Graphics gra, Point cur)
        {
            if (selBrush.getBrush() == 4)
            {
                if (spraying)
                {
                    Sprayer.Spray(gra, (int)pen.Width, cur, color);
                }
            }
        }

        public void ProcessMouseDown(Bitmap bm, Graphics gra, Point old, Point cur)
        {   
            color = Color.FromArgb(opacitySlide.Value, colorPanel.getColor1());
            pen = new Pen(color, thicknessSlide.Value);
            pen.DashStyle = DashStyle.Solid;
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

            gra.CompositingMode = CompositingMode.SourceOver;
            gra.SmoothingMode = SmoothingMode.AntiAlias;
            gra.CompositingQuality = CompositingQuality.GammaCorrected;

            switch (selBrush.getBrush())
            {
                case 0: //marker
                    _pts = new List<Point>();
                    _pts.Add(cur);
                    break;
                case 1: //eraser 
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
                    spraying = true;
                    Sprayer.Spray(gra, (int)pen.Width, cur, color);
                    break;
            }
        }

        public void ProcessMouseUp(Bitmap bm, Point cur)
        {
            if (selBrush.getBrush() == 0 || selBrush.getBrush() == 1)
            {
                _pts = new List<Point>();
            }
            if (pickerActive)
            {
                colorPanel.getPixelColor(bm, cur);
                pickerActive = false;
            }
            if(selBrush.getBrush() == 4)
            {
                spraying = false;
            }
        }

        public void ProcessPaint(Graphics gra, Point old, Point cur)
        {
            if (!pickerActive )
            {
                GraphicsPath gPath = new GraphicsPath();
                switch (selBrush.getBrush())
                {
                    case 0: //marker
                        if (_pts!=null)
                        {
                            gra.CompositingMode = CompositingMode.SourceOver;
                            gra.SmoothingMode = SmoothingMode.AntiAlias;
                            _pts.Add(cur);
                            gPath.AddLines(_pts.ToArray());
                            pen.LineJoin = LineJoin.Round;
                            gra.CompositingMode = CompositingMode.SourceOver;
                            gra.DrawPath(pen, gPath);
                        }
                        break;
                    case 1: //eraser
                        if (_pts!=null)
                        {
                            gra.CompositingMode = CompositingMode.SourceCopy;
                            gra.SmoothingMode = SmoothingMode.None;
                            _pts.Add(cur);
                            gPath.AddLines(_pts.ToArray());

                            pen = new Pen(Color.Transparent, thicknessSlide.Value);
                            pen.LineJoin = LineJoin.Round;

                            gra.CompositingMode = CompositingMode.SourceCopy;
                            gra.DrawPath(pen, gPath);
                        }
                        break;
                    case 3:
                        MessageBox.Show("3");
                        break;
                    case 4:
                        
                        break;
                    default:
                        break;
                }
            }
        }

        //get
        public int getThickness()
        {
            return thicknessSlide.Value;
        }

        public int getOpacity()
        {
            return opacitySlide.Value;
        }

    }
}

