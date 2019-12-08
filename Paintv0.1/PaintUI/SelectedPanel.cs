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
    public partial class SelectedPanel : UserControl
    {
        bool isDown;
        

        public SelectedPanel()
        {
            InitializeComponent();
            isDown = false;
        }

        private void SelectedPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void SelectedPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                MessageBox.Show(this.Location.X.ToString() + this.Location.Y.ToString());
            }
        }

        private void SelectedPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
