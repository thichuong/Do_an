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
    public partial class ColorPanel : UserControl
    {
        public ColorPanel()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox colorCell = sender as PictureBox;
            mainColor1.BackColor = colorCell.BackColor;
        }

        private void addColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                mainColor1.BackColor = cld.Color;
            }
        }

        public Color getColor1()
        {
            return mainColor1.BackColor;
        }
        public Color getColor2()
        {
            return mainColor2.BackColor;
        }

        private void mainColor1_Click(object sender, EventArgs e)
        {
            mainColor1.BringToFront();
        }

        private void mainColor2_Click(object sender, EventArgs e)
        {
            mainColor2.BringToFront();
        }
    }
}
