using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PaintUI.Code.Class
{
    class StackListBitmap
    {
        Stack<List<Bitmap>> StackListBM;
        public StackListBitmap()
        {
            StackListBM = new Stack<List<Bitmap>>();
        }
        public void Push(List<Bitmap> bitmaps,Bitmap bmp)
        {
            List<Bitmap> tempList = new List<Bitmap>();
            tempList.Add((Bitmap)bmp.Clone());
            for(int i=0;i<bitmaps.Count();i++)
            {
                tempList.Add((Bitmap)bitmaps[i].Clone());
            }
            StackListBM.Push(tempList);
        }
        public int Count()
        {
            return StackListBM.Count();
        }
        public List<Bitmap> Pop()
        {
            List<Bitmap> tempList = new List<Bitmap>();
            List<Bitmap> bitmaps = StackListBM.Pop();
            for (int i = 1; i < bitmaps.Count(); i++)
            {
                tempList.Add((Bitmap)bitmaps[i].Clone());
            }
            return tempList;
        }
        public Bitmap PopBitmap()
        {
            return StackListBM.Peek()[0];
        }
        public Bitmap PeekBitmap()
        {
            return StackListBM.Peek()[0];
        }
        public List<Bitmap> Peek()
        {
            return StackListBM.Peek();
        }
    }
}
