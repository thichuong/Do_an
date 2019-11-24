
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
       
        public BrushesPanel()
        {
            InitializeComponent();
            
            pen = new Pen(colorPanel.getColor1(), thicknessSlide.Value);

            curBrushBtn.BackgroundImage = ResizeImg(curBrushBtn.BackgroundImage, 50, 50);

            thicknessSlide.Value = 10;
            opacitySlide.Value = 255;
            thicknessSlide.MaximumValue = 30;
            
            selBrush = new BrushesSelection();
            selBrush.Location = new Point(0, curBrushBtn.Location.Y + curBrushBtn.Size.Height + 10);
            selBrush.Size = new Size(Width + 20, 0);
            Controls.Add(selBrush);
            selBrush.Show();
            selBrush.BringToFront();

            selBrush.BrushSelected += SelBrush_BrushSelected;
        }

        public static Image ResizeImg(Image originalImage, int w, int h)
        {
            //Original Image attributes
            int originalWidth = originalImage.Width;
            int originalHeight = originalImage.Height;

            // Figure out the ratio
            double ratioX = (double)w / (double)originalWidth;
            double ratioY = (double)h / (double)originalHeight;
            // use whichever multiplier is smaller
            double ratio = ratioX < ratioY ? ratioX : ratioY;

            // now we can get the new height and width
            int newHeight = Convert.ToInt32(originalHeight * ratio);
            int newWidth = Convert.ToInt32(originalWidth * ratio);

            Image thumbnail = new Bitmap(newWidth, newHeight);
            Graphics graphic = Graphics.FromImage(thumbnail);

            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;

            graphic.Clear(Color.Transparent);
            graphic.DrawImage(originalImage, 0, 0, newWidth, newHeight);

            return thumbnail;
        }

        private void SelBrush_BrushSelected(object sender, EventArgs e)
        {
            curBrushBtn.BackgroundImage = selBrush.getImage();
            
            Slider slider = new Slider(selBrush);
        }

        private void curBrushBtn_Click(object sender, EventArgs e)
        {
            Slider slider = new Slider(selBrush);
        }
        

        //Cac thao tac voi trang ve
        public void ProcessMouseDown(Bitmap bm, Graphics gra, Point old, Point cur)
        {
            Color color = Color.FromArgb(opacitySlide.Value, colorPanel.getColor1());
            pen = new Pen(color, thicknessSlide.Value);
            pen.DashStyle = DashStyle.Solid;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            
            gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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
                    FillBucket bucket = new FillBucket();
                    Color pointColor = Color.FromArgb(255, bm.GetPixel(old.X, old.Y));
                    color = Color.FromArgb(opacitySlide.Value, colorPanel.getColor2());
                    bucket.Fill(bm, old, pointColor, color);
                    break;
                case 3:
                    break;

            }
        }

        public void ProcessPaint(Graphics gra, Point old, Point cur)
        {
            GraphicsPath gPath = new GraphicsPath();
            switch (selBrush.getBrush())
            {
               
                case 0: //marker
                    gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                    gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    _pts.Add(cur);
                    gPath.AddLines(_pts.ToArray());
                    pen.LineJoin = LineJoin.Round;
                    gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                    gra.DrawPath(pen, gPath);
                    break;
                case 1: //eraser
                    gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                    gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    _pts.Add(cur);
                    gPath.AddLines(_pts.ToArray());
                    pen = new Pen(Color.Transparent, thicknessSlide.Value);
                    pen.LineJoin = LineJoin.Round;
                    gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                    gra.DrawPath(pen, gPath);
                    break;
                default:
                    break;
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

        private void curBrushBtn_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}

