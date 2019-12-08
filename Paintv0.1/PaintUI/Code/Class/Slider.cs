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

        
        public void Sliding(object tar)
        {
            ProcessSliding(tar);
        }
        
        private void ProcessSliding(object tar)
        {
            if (tar is ShapeSelections)
            {
                maxHeight = 210;
                type = 0;
                shapeTar = (ShapeSelections)tar;

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
            else if (tar is BrushesSelection)
            {
                maxHeight = 200;
                type = 1;
                brushTar = (BrushesSelection)tar;

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
