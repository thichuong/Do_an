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
    public partial class Ribbon : UserControl
    {
        Form1 parent;
        public Ribbon()
        {
            InitializeComponent();
            parent = (Form1)this.ParentForm;
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
        }

        private void ShapesButton_Click(object sender, EventArgs e)
        {

        }

        private void CanvasButton_Click(object sender, EventArgs e)
        {

        }

        private void BrushesButton_Click(object sender, EventArgs e)
        {

        }

        private void EffectsButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowPanel(BrushesPanel tar)
        {

        }

        private void ShowPanel(EffectsPanel tar)
        {

        }

        //private void ShowPanel(ShapesPanel tar)
        //{
        //    if (!tar.Visible)
        //    {
        //        HideAllPanel();
        //        tar.Show();
        //    }
        //    curTool = Tools.SHAPE;
        //}

        //private void ShowPanel(CanvasPanel tar)
        //{

        //}

        //private void ShowPanel(TextPanel tar)
        //{
        //    if (!tar.Visible)
        //    {
        //        HideAllPanel();
        //        tar.Show();
        //    }
        //}
    }
}
