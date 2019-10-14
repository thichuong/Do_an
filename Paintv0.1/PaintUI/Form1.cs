using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideAllPanel();  
        }
        //Giau Panels
        private void HideAllPanel()
        {
            ShapesPanel.Visible = false;
            TextPanel.Visible = false;
            CanvasPanel.Visible = false;
            BrushesPanel.Visible = false;
            EffectsPanel.Visible = false;
            MenuPanel.Visible = false;
        }
        //Code cac chuc nang cho cac WindowState Butttons
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Hien thi cac Panels khi click
        private void TextButton_Click(object sender, EventArgs e)
        {
            if (!TextPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(TextPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
                bunifuTransition1.HideSync(TextPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
        }
        private void ShapesButton_Click(object sender, EventArgs e)
        {
            if (!ShapesPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(ShapesPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else

                bunifuTransition1.HideSync(ShapesPanel, false, BunifuAnimatorNS.Animation.HorizSlide);          
        }
        private void CanvasButton_Click(object sender, EventArgs e)
        {
            if (!CanvasPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(CanvasPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else           
                bunifuTransition1.HideSync(CanvasPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void BrushesButton_Click(object sender, EventArgs e)
        {
            if (!BrushesPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(BrushesPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
            
                bunifuTransition1.HideSync(BrushesPanel, false, BunifuAnimatorNS.Animation.HorizSlide);      
        }
        private void EffectsButton_Click(object sender, EventArgs e)
        {
            if (!EffectsPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(EffectsPanel, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
                bunifuTransition1.HideSync(EffectsPanel, false, BunifuAnimatorNS.Animation.HorizSlide);            
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (!MenuPanel.Visible)
            {
                HideAllPanel();
                bunifuTransition1.ShowSync(MenuPanel, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
                bunifuTransition1.HideSync(MenuPanel, false, BunifuAnimatorNS.Animation.VertSlide);
        }

        //---------------

    }
}
