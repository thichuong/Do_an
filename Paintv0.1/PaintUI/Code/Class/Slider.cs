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
        int type, vel, unit=20, maxHeight;
        ShapeSelections shapeTar;
        BrushesSelection brushTar;
        
        public void Sliding(ShapeSelections tar)
        {
            maxHeight = 250;
            type = 0;
            shapeTar = tar;

            if (shapeTar.Height >= maxHeight)
            {
                vel = -unit;
            }

            if (shapeTar.Height <= 0)
            {
                vel = unit;
            }

            timer = new Timer();
            timer.Interval = 5;
            timer.Start();

            timer.Tick += Timer_Tick;
        }
        
        public void Sliding(BrushesSelection tar)
        {
            maxHeight = 200;
            type = 1;
            brushTar = tar;

            if (brushTar.Height >= maxHeight)
            {
                vel = -unit;
            }

            if (brushTar.Height <= 0)
            {
                vel = unit;
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
                shapeTar.Height += vel;

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
                brushTar.Height += vel;

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
