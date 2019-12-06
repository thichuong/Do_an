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
using Bunifu.Framework.UI;

namespace PaintUI
{
    public partial class ShapeSelections : UserControl
    {
        int curShape;   //0.rec 1.elp 2.line 3.arr 4.star 5.tri 6.lgt 7.iso 8.hex
        Image curImg;
        
        public event EventHandler ShapeSelected;

        public ShapeSelections()
        {
            InitializeComponent();
            curShape = 0;
            curImg = recBtn.BackgroundImage;

            SetRevolution();
        }

        private void SetRevolution()
        {
            ResizeHelper.SetRevolution(recBtn);
            ResizeHelper.SetRevolution(elpBtn);
            ResizeHelper.SetRevolution(lineBtn);
            ResizeHelper.SetRevolution(arwBtn);
            ResizeHelper.SetRevolution(starBtn);
            ResizeHelper.SetRevolution(triBtn);
            ResizeHelper.SetRevolution(lgtBtn);
            ResizeHelper.SetRevolution(isoBtn);
            ResizeHelper.SetRevolution(hexBtn);
            ResizeHelper.SetRevolution(hrtBtn);
            ResizeHelper.SetRevolution(bunifuFlatButton2);
            ResizeHelper.SetRevolution(bunifuFlatButton3);

        }

        private void recBtn_Click(object sender, EventArgs e)
        {
            curShape = 0;
            curImg = recBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void elpBtn_Click(object sender, EventArgs e)
        {
            curShape = 1;
            curImg = elpBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            curShape = 2;
            curImg = lineBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void arwButton_Click(object sender, EventArgs e)
        {
            curShape = 3;
            curImg = arwBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void starBtn_Click(object sender, EventArgs e)
        {
            curShape = 4;
            curImg = starBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void triBtn_Click(object sender, EventArgs e)
        {
            curShape = 5;
            curImg = triBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void lgtBtn_Click(object sender, EventArgs e)
        {
            curShape = 6;
            curImg = lgtBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void isoBtn_Click(object sender, EventArgs e)
        {
            curShape = 7;
            curImg = isoBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void hexBtn_Click(object sender, EventArgs e)
        {
            curShape = 8;
            curImg = hexBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }
        
        private void hrtBtn_Click(object sender, EventArgs e)
        {
            curShape = 9;
            curImg = hrtBtn.BackgroundImage;
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        public int getShape()
        {
            return curShape;
        }

        public Image getImage()
        {
            return curImg;
        }

    }
}
