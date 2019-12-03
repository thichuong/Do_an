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
        int curBrush; //0.marker 1.eraser 2.fill 3.pencil 4.spray
        Image curImage;
        

        public BrushesSelection()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 5);
            curBrush = 0;
            curImage = marBtn.BackgroundImage;
            
            SetRevolution();


        }

        private void SetRevolution()
        {
            ResizeHelper.SetRevolution(marBtn);
            ResizeHelper.SetRevolution(eraBtn);
            ResizeHelper.SetRevolution(fillBtn);
            ResizeHelper.SetRevolution(peciBtn);
            ResizeHelper.SetRevolution(sprBtn);
            ResizeHelper.SetRevolution(bunifuFlatButton5);
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

        private void sprBtn_Click(object sender, EventArgs e)
        {
            curBrush = 4;
            curImage = sprBtn.BackgroundImage;
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