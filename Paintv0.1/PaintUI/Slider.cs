using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI
{
    class Slider
    {
        Timer timer;

        int type;

        int unit;
        int maxHeight;

        ShapeSelections shapeTar;
        BrushesSelection brushTar;
        

        public Slider(ShapeSelections tar)
        {
            maxHeight = 250;
            type = 0;
            shapeTar = tar;

            if (shapeTar.Height >= maxHeight)
            {
                unit = -10;
            }

            if (shapeTar.Height <= 0)
            {
                unit = 10;
            }

            timer = new Timer();
            timer.Interval = 5;
            timer.Start();

            timer.Tick += Timer_Tick;
        }

        public Slider(BrushesSelection tar)
        {
            maxHeight = 200;
            type = 1;
            brushTar = tar;

            if (brushTar.Height >= maxHeight)
            {
                unit = -10;
            }

            if (brushTar.Height <= 0)
            {
                unit = 10;
            }

            timer = new Timer();
            timer.Interval = 10;
            timer.Start();

            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (type == 0)
            {
                shapeTar.Height += unit;

                if (shapeTar.Height <= 0)
                {
                    timer.Stop();
                }
                if (shapeTar.Height >= maxHeight)
                {
                    timer.Stop();
                }
            }
            else
            {
                brushTar.Height += unit;

                if (brushTar.Height <= 0)
                {
                    timer.Stop();
                }
                if (brushTar.Height >= maxHeight)
                {
                    timer.Stop();
                }
            }
        }
        
    }
}
