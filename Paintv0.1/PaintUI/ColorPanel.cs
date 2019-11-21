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
        int select;
        public ColorPanel()
        {
            InitializeComponent();
            mainColor1.BringToFront();
            select = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox colorCell = sender as PictureBox;
            if (select == 1)
            {
                mainColor1.BackColor = colorCell.BackColor;
            }
            else
            {
                mainColor2.BackColor = colorCell.BackColor;
            }
            
        }

        private void addColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                if(select==1)
                {
                    mainColor1.BackColor = cld.Color;
                }
                else
                {
                    mainColor2.BackColor = cld.Color;
                }
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
            select = 1;
        }

        private void mainColor2_Click(object sender, EventArgs e)
        {
            mainColor2.BringToFront();
            select = 2;
        }
    }
}
