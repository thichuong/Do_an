
﻿using System;
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
    public partial class BrushesPanel : UserControl
    {
        enum Brushes { MARKER, PENCIL, ERASER, FILL};
        Brushes curBrush;

        bool isShown;
        
        BrushesSelection selBrush;

        public BrushesPanel()
        {
            InitializeComponent();
            thicknessSlide.Value = 10;
            opacitySlide.Value = 255;
            thicknessSlide.MaximumValue = 30;

            curBrush = Brushes.MARKER;

            isShown = false;

            selBrush = new BrushesSelection();
            selBrush.Location = new Point(0, curBrushBtn.Location.Y + curBrushBtn.Size.Height + 10);
            selBrush.Size = new Size(Width + 40, Width);
            Controls.Add(selBrush);
            selBrush.BringToFront();
            selBrush.Hide();

            selBrush.BrushSelected += SelBrush_BrushSelected;
        }

        private void SelBrush_BrushSelected(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void curBrushBtn_Click(object sender, EventArgs e)
        {
            if (isShown)
            {
                selBrush.Hide();
                //bunifuTransition1.HideSync(selBrush, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
            {
                selBrush.Show();
                //bunifuTransition1.ShowSync(selBrush, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            isShown = !isShown;
        }

        public int getThickness()
        {
            return thicknessSlide.Value;
        }

        public int getOpacity()
        {
            return opacitySlide.Value;
        }

        
    }
}

