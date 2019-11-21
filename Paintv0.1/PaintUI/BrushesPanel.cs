
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

        Pen pen;
        
        public BrushesPanel()
        {
            InitializeComponent();
            
            pen = new Pen(colorPanel.getColor1(), thicknessSlide.Value);

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
            pen = new Pen(Color.Black, thicknessSlide.Value);
            pen.DashStyle = DashStyle.Solid;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            
            gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gra.CompositingQuality = CompositingQuality.GammaCorrected;


            switch (selBrush.getBrush())
            {
                case 0: //marker
                    gra.FillEllipse(pen.Brush, cur.X - thicknessSlide.Value / 2, cur.Y - thicknessSlide.Value / 2, thicknessSlide.Value, thicknessSlide.Value);
                    break;
                case 1: //eraser
                    break;
                case 2: //fill
                    FillBucket bucket = new FillBucket();
                    bucket.Fill(bm, old, bm.GetPixel(old.X, old.Y), pen.Color);
                    break;
                case 3:
                    break;

            }
        }

        public void ProcessPaint(Graphics gra, Point old, Point cur)
        {
            switch (selBrush.getBrush())
            {
                case 0: //marker
                    gra.DrawLine(pen, old, cur);
                    break;
                case 1: //eraser
                    Pen temp = new Pen(Color.Transparent, thicknessSlide.Value);
                    temp.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
                    gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                    gra.DrawLine(temp, old, cur);
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

