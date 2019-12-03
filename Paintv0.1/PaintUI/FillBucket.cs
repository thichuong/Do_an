using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PaintUI
{
    class FillBucket
    {
        public FillBucket()
        {

        }

        public void Fill(Bitmap bmp, Point pt, Color pointColor, Color replaceColor)
        {
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);
            int x = pt.X, y = pt.Y;
            Stack<Point> check = new Stack<Point>();
            int To = replaceColor.ToArgb();
            int From = bits[x + y * data.Stride /4];
            bits[x + y * data.Stride / 4] = To;
            if (To != From)
            {
                Bitmap tempBmp = new Bitmap(bmp.Width,bmp.Height);
                BitmapData tempdata= tempBmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                int[] tempbits = new int[tempdata.Stride / 4 * tempdata.Height];
                Marshal.Copy(tempdata.Scan0, tempbits, 0, tempbits.Length);
                check.Push(new Point(x, y));  
                while (check.Count > 0)
                {
                    Point cur = check.Pop();
                    Point next = new Point(cur.X, cur.Y - 1);
                    foreach (Point off in new Point[] {
                        new Point(0, -1), new Point(0, 1),
                        new Point(-1, 0), new Point(1, 0)})
                    {
                        next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 && next.X < data.Width &&next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == From)
                            {
                                check.Push(next);
                            }
                            bits[next.X + next.Y * data.Stride / 4] = To;
                            tempbits[next.X + next.Y * data.Stride / 4] = To;
                        }
                    }
                }
                Marshal.Copy(tempbits, 0, tempdata.Scan0, tempbits.Length);
                bmp.UnlockBits(data);
                tempBmp.UnlockBits(tempdata);
                Graphics gra = Graphics.FromImage(bmp);
                gra.SmoothingMode = SmoothingMode.AntiAlias;
                gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gra.DrawImage(tempBmp, 0, 0, bmp.Width, bmp.Height);
            }
            else
            {
                Bitmap tempbmp = new Bitmap(bmp.Width, bmp.Height);
                BitmapData tempdata = tempbmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                int[] tempbits = new int[tempdata.Stride / 4 * tempdata.Height];
                Marshal.Copy(tempdata.Scan0, tempbits, 0, tempbits.Length);
                check.Push(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.Pop();
                    Point next = new Point(cur.X, cur.Y - 1);
                    foreach (Point off in new Point[] {
                new Point(0, -1), new Point(0, 1),
                new Point(-1, 0), new Point(1, 0)})
                    {
                        next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == From)
                            {
                                check.Push(next);
                                bits[next.X + next.Y * data.Stride / 4] = Color.Transparent.ToArgb();
                                tempbits[next.X + next.Y * data.Stride / 4] = To;
                            }
                           
                        }
                    }
                }
                Marshal.Copy(tempbits, 0, tempdata.Scan0, tempbits.Length);
                bmp.UnlockBits(data);
                tempbmp.UnlockBits(tempdata);
                Graphics gra = Graphics.FromImage(bmp);
                gra.SmoothingMode = SmoothingMode.AntiAlias;
                gra.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gra.DrawImage(tempbmp, 0, 0, bmp.Width, bmp.Height);
            }
        }
    }
}
