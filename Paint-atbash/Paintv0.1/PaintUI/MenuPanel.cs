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
    public partial class MenuPanel : UserControl
    {
        public event EventHandler ButtonClick;
        public MenuPanel()
        {
            InitializeComponent();
        }
        

        private void backButton_Click(object sender, EventArgs e)
        {
            this.bunifuTransition2.HideSync(this, false, BunifuAnimatorNS.Animation.HorizSlide);

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
            this.bunifuTransition2.HideSync(this, false, BunifuAnimatorNS.Animation.HorizSlide);
        }
    }
}
