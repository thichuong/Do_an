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
        public event EventHandler NewButtonClick;
        public event EventHandler OpenButtonClick;
        public event EventHandler SaveButtonClick;
        public event EventHandler SaveAsButtonClick;

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
            if (this.NewButtonClick != null)
                this.NewButtonClick(this, e);
            this.bunifuTransition2.HideSync(this, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (this.OpenButtonClick != null)
                this.OpenButtonClick(this, e);
            this.bunifuTransition2.HideSync(this, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.SaveButtonClick != null)
                this.SaveButtonClick(this, e);
            this.bunifuTransition2.HideSync(this, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if (this.SaveAsButtonClick != null)
                this.SaveAsButtonClick(this, e);
            this.bunifuTransition2.HideSync(this, false, BunifuAnimatorNS.Animation.HorizSlide);
        }
    }
}
