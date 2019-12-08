using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI.Code.Class
{
    class SketchBoxEffect
    {
        static public void SketchBoxVisionImage(Bitmap bmp, PictureBox SketchBox, EffectsPanel effectsPanel, Bitmap visionBM)
        {
            Bitmap effectBM = new Bitmap(SketchBox.Width, SketchBox.Height);
            Graphics graphics = Graphics.FromImage(effectBM);
            graphics.Clear(effectsPanel.color);
            visionBM = new Bitmap(SketchBox.Width, SketchBox.Height);
            graphics = Graphics.FromImage(visionBM);
            graphics.DrawImage(bmp, 0, 0, SketchBox.Width, SketchBox.Height);
            graphics.DrawImage(effectBM, 0, 0, SketchBox.Width, SketchBox.Height);
            SketchBox.BackgroundImage = (Bitmap)visionBM.Clone();
        }
    }
}
