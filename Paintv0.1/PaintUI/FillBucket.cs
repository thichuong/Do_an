using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
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
            int From = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = To;
            if (From != To)
            {
                check.Push(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.Pop();

                    Point next = new Point(cur.X, cur.Y - 1);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X, cur.Y + 1);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X - 1, cur.Y);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);
                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X + 1, cur.Y);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }

                }
                while (check.Count > 0)
                {
                    Point cur = check.Pop();

                    Point next = new Point(cur.X, cur.Y - 1);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X, cur.Y + 1);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X - 1, cur.Y);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);
                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }
                    next = new Point(cur.X + 1, cur.Y);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {

                        if (bits[next.X + next.Y * data.Stride / 4] == From)
                        {
                            check.Push(next);

                        }
                        bits[next.X + next.Y * data.Stride / 4] = To;
                    }

                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bmp.UnlockBits(data);

        }

    }
}
