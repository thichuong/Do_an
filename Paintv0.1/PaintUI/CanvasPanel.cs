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
    public partial class CanvasPanel : UserControl
    {
        //int trackkeypoint = 0;
        public bool ShowCheckBox;
        int wid, hei;
        public CanvasPanel()
        {
            InitializeComponent();
            Canvas_TransparentCheckBox.Checked = false;
            Canvas_ShowCheckBox.Checked = true;
            ShowCheckBox = Canvas_ShowCheckBox.Checked;
            wid = 0;
            hei = 0;
        }
        public void setCanvasText(Canvas SketchBox)
        {
            if (wid != SketchBox.Width)
            {
                Canvas_Width.Text = SketchBox.Width.ToString();
                wid = SketchBox.Width;
            }
            else
                Canvas_Width.Text = wid.ToString();
            if (hei != SketchBox.Height)
            {
                Canvas_Height.Text = SketchBox.Height.ToString();
                hei = SketchBox.Height;
            }
            else
                Canvas_Height.Text = hei.ToString();
        }
        public int getCanvasTextWidth()
        {
            return Int32.Parse(Canvas_Width.Text);
        }
          
       public int getCanvasTextHeight()
        {
            return Int32.Parse(Canvas_Height.Text);
        }
        private void Canvas_textBoxKeypress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            if (keycode >= 48 && keycode <= 57 || keycode == 8 )
            {    
            }
            else e.Handled = true;
            if(keycode==13)
            {
                Form1 parent = (Form1)this.ParentForm;
                parent.resizeSketchBox();
            }
        }     

        private void CanvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 parent = (Form1)this.ParentForm;
            parent.resizeSketchBox();
        }

        private void _Click(object sender, EventArgs e)
        {

            Form1 parent = (Form1)this.ParentForm;
            parent.resizeSketchBox();
        }

        private void Canvas_TransparentCheckBox_OnChange(object sender, EventArgs e)
        {
            
                Form1 parent = (Form1)this.ParentForm;
                parent.SketchBoxTransparent();
            
        }

        private void Canvas_ShowCheckBox_OnChange(object sender, EventArgs e)
        {
            ShowCheckBox = Canvas_ShowCheckBox.Checked;
            Form1 parent = (Form1)this.ParentForm;
            parent.SketchBoxShowResizepanel();
        }
    }
}
