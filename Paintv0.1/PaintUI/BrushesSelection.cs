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
    public partial class BrushesSelection : UserControl
    {
        public event EventHandler BrushSelected;

        Pen pen;
        int curBrush; //0.marker 1.eraser 2.fill 3.pencil
        Image curImage;


        public BrushesSelection()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 5);
            curBrush = 0;
            curImage = marBtn.BackgroundImage;
        }

        private void marBtn_Click(object sender, EventArgs e)
        {
            curBrush = 0;
            curImage = marBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.BrushSelected != null)
                this.BrushSelected(this, e);
        }

        private void eraBtn_Click(object sender, EventArgs e)
        {
            curBrush = 1;
            curImage = eraBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.BrushSelected != null)
                this.BrushSelected(this, e);
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            curBrush = 2;
            curImage = fillBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.BrushSelected != null)
                this.BrushSelected(this, e);
        }

        private void peciBtn_Click(object sender, EventArgs e)
        {
            curBrush = 3;
            curImage = peciBtn.BackgroundImage;
            this.bunifuTransition1.HideSync(this, false, BunifuAnimatorNS.Animation.VertSlide);
            if (this.BrushSelected != null)
                this.BrushSelected(this, e);
        }

        public int getBrush()
        {
            return curBrush;
        }

        public Image GetImage()
        {
            return curImage;
        }
    }
}