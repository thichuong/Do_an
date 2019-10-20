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
        public event EventHandler ColorChange;

        public ColorPanel()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox colorCell = sender as PictureBox;
            mainColor.BackColor = colorCell.BackColor;
        }

        private void addColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                mainColor.BackColor = cld.Color;
            }
        }

        public Color getColor()
        {
            return mainColor.BackColor;
        }
    }
}
