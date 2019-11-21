using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void recBtn_Click(object sender, EventArgs e)
        {
            curShape = 0;
            curImg = recBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void elpBtn_Click(object sender, EventArgs e)
        {
            curShape = 1;
            curImg = elpBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            curShape = 2;
            curImg = lineBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void arwButton_Click(object sender, EventArgs e)
        {
            curShape = 3;
            curImg = arwButton.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void starBtn_Click(object sender, EventArgs e)
        {
            curShape = 4;
            curImg = starBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void triBtn_Click(object sender, EventArgs e)
        {
            curShape = 5;
            curImg = triBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void lgtBtn_Click(object sender, EventArgs e)
        {
            curShape = 6;
            curImg = lgtBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void isoBtn_Click(object sender, EventArgs e)
        {
            curShape = 7;
            curImg = isoBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.ShapeSelected != null)
                this.ShapeSelected(this, e);
        }

        private void hexBtn_Click(object sender, EventArgs e)
        {
            curShape = 8;
            curImg = hexBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
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
