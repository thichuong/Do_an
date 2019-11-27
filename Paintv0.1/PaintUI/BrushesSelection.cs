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
    public partial class BrushesSelection : UserControl
    {
        public event EventHandler BrushSelected;

        Pen pen;
        int curBrush; //0.marker 1.eraser 2.fill 3.pencil
        Image curImage;

        int unit;

        public BrushesSelection()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 5);
            curBrush = 0;
            curImage = marBtn.BackgroundImage;

            unit = 50;
            SetRevolution();


        }

        private static Image ResizeImg(Image originalImage, int w, int h)
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

        private void SetRevolution()
        {
            marBtn.BackgroundImage = ResizeImg(marBtn.BackgroundImage, unit, unit);
            eraBtn.BackgroundImage = ResizeImg(eraBtn.BackgroundImage, unit, unit);
            fillBtn.BackgroundImage = ResizeImg(fillBtn.BackgroundImage, unit, unit);
            peciBtn.BackgroundImage = ResizeImg(peciBtn.BackgroundImage, unit, unit);
            bunifuFlatButton4.BackgroundImage = ResizeImg(bunifuFlatButton4.BackgroundImage, unit, unit);
            bunifuFlatButton5.BackgroundImage = ResizeImg(bunifuFlatButton5.BackgroundImage, unit, unit);
        }

        private void marBtn_Click(object sender, EventArgs e)
        {
            curBrush = 0;
            curImage = marBtn.BackgroundImage;
            if (this.BrushSelected != null)
                this.BrushSelected(this, e);
        }

        private void eraBtn_Click(object sender, EventArgs e)
        {
            curBrush = 1;
            curImage = eraBtn.BackgroundImage;
            if (this.BrushSelected != null)
                this.BrushSelected(this, e);
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            curBrush = 2;
            curImage = fillBtn.BackgroundImage;
            if (this.BrushSelected != null)
                this.BrushSelected(this, e);
        }

        private void peciBtn_Click(object sender, EventArgs e)
        {
            curBrush = 3;
            curImage = peciBtn.BackgroundImage;
            if (this.BrushSelected != null)
                this.BrushSelected(this, e);
        }

        public int getBrush()
        {
            return curBrush;
        }

        public Image getImage()
        {
            return curImage;
        }

    }
}