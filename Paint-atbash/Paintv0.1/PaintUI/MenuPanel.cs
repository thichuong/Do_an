﻿using System;
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
        public MenuPanel()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.bunifuTransition2.HideSync(this, false, BunifuAnimatorNS.Animation.HorizSlide);

        }
    }
}
